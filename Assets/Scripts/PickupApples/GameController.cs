using NUnit.Framework;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class GameController : MonoBehaviour
{
    //Para proporcionar el Prefab de la manzana
    [SerializeField] private GameObject applePrefab;
    //Para la gravedad
    [SerializeField] private float gravity;
    //Transform del player
    [SerializeField] private Transform playerTransform;
    //Score en pantalla
    [SerializeField] private TMP_Text scoreText;

    //Temporizador para que se cree una nueva manzana
    private float timer;
    //Para guardar los puntos por cada manzana
    private int score;
    
    //Lista (generica) de manzanas
    private List<GameObject> appleList = new List<GameObject>();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scoreText.text = "Score 0";
        //Timer en Start para que empiece en 0 nada mas comenzar
        timer = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        //Incrementamos el timer
        timer += Time.deltaTime;

        if( timer > 2f)
        {
            //Se ha completado el timer
            //Reseteamos
            timer = 0f;

            //Creamos una manzana
            GameObject newApple = Instantiate(applePrefab);

            //Posicionamos la manzana en la parte superior
            newApple.transform.position = new Vector3(Random.Range(-3.5f, 3.5f), 5.5f);

            //Guardo la manzana creada en la lista.
            appleList.Add(newApple);
        }
        //Creamos otra lista para guardar las manzanas que queremos eliminar
        List<GameObject> appleListToRemove = new List<GameObject>();
        //Mover todas las manzanas
        foreach (GameObject apple in appleList)
        {
            apple.transform.position += Vector3.down * gravity * ((score+1.0f) / 10.0f) * Time.deltaTime;

            //Queremos que el player recoja las manzanas
            //Para cada manzana
            //Compruebo si el player está "cerca
            float distance = Vector3.Distance(apple.transform.position, playerTransform.position); //Utilizo la funcion distance de vector3
            if(distance < 0.5f)
            {
                //Quiero que la manzana se elimine
                Debug.Log("Colision de la manzana");

                //Puntuacion
                score++;//Puntuacion por manzana
                scoreText.text = "Score: " + score.ToString(); //El canva se actualiza con el score
                Debug.Log("Score: " + score);//Impresion por consola de score

                appleListToRemove.Add(apple); //Añado a la lista ToRemove las manzanas que quiero eliminar
            }

        }
        //Eliminamos las manzanas guardadas en la lista ToRemove
        foreach (GameObject apple in appleListToRemove)
        {
            appleList.Remove(apple);

            Destroy(apple);
        }

        appleListToRemove.Clear();

    }
}
