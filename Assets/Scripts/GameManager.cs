using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //TODO

    // Prefab del enemigo que vamos a generar
    // Exponerlo en el editor
    // public GameObject enemyPrefab; (otra opcion)
    [SerializeField] private GameObject enemyPrefab;

    [SerializeField] private float speed = 2.0f;

    // ARRAY:
    // Las posiciones posibles son conocidas y no cambiarán
    // durante la ejecución del juego.
    [SerializeField] private Transform[] spawnPoints;

    // Número de enemigos que queremos generar en cada ronda
    [SerializeField] private int numberOfEnemies = 5;

    // LIST:
    // El número de enemigos vivos sí cambiará durante la partida.
    private List<GameObject> activeEnemies = new List<GameObject>();

    private int score = 0;

    GameObject createdEnemy;
    //Score
    void Start()
    {
        //TODO: Llamamos a la generación de enemigos
        GenerarEnemigos();

        // Instanciar un enemigo
        // createdEnemy = Instantiate(enemyPrefab, Vector3.zero, Quaternion.identity);

        //Otra opcion: createdEnemy.transform.position += new Vector3(3.0f, 0f, 0f);
        //Que se desplace 3 unidades en el eje X
        
    }

    void Update()
    {
        //TODO:  Reiniciamos la ronda pulsando R
        /*
        createdEnemy.transform.position = new Vector3(createdEnemy.transform.position.x + 3 * Time.deltaTime * speed, createdEnemy.transform.position.y, createdEnemy.transform.position.z);
        if(createdEnemy.transform.position.x > 13)
        {
            createdEnemy.transform.position = Vector3.zero;
        }
        */

        /*if(createdEnemy.transform.position.x > 13)
        {
            createdEnemy.transform.position = new Vector3(createdEnemy.transform.position.x - 3 * Time.deltaTime * speed, createdEnemy.transform.position.y, createdEnemy.transform.position.z);
        }
        else if (createdEnemy.transform.position.x < -13)
        {
            createdEnemy.transform.position = new Vector3(createdEnemy.transform.position.x + 3 * Time.deltaTime * speed, createdEnemy.transform.position.y, createdEnemy.transform.position.z);
        }
        */
    }

    //Generar oleada
    private void GenerarEnemigos()
    {
        //TODO: 
        // Evitamos intentar generar más enemigos
        // que posiciones disponibles.

        // ARRAY auxiliar:
        // Nos permite saber qué posiciones ya hemos utilizado.
        //
        // false = libre
        // true = ocupada
        bool[] ocupados = new bool[spawnPoints.Length];

        // FOR:
        // Sabemos cuántos enemigos queremos generar.
        for (int i = 0; i < numberOfEnemies; i++)
        {

            // Elegimos una posición aleatoria.
            int randomPosition = Random.Range(0, spawnPoints.Length);

            // WHILE:
            // Mientras esa posición ya esté ocupada,
            // buscamos otra.
            while (ocupados[randomPosition])
            {
                randomPosition = Random.Range(0, spawnPoints.Length);
            }

            ocupados[randomPosition] = true;
            // Marcamos esa posición como utilizada.

            // Creamos el enemigo.
            createdEnemy = Instantiate(enemyPrefab, spawnPoints[randomPosition].position, Quaternion.identity);

            // Guardamos el enemigo en nuestra lista
            // de enemigos actualmente vivos.
            activeEnemies.Add(createdEnemy);

            // Le damos al enemigo una referencia
            // al GameManager.
            EnemyScript eScript = createdEnemy.GetComponent<EnemyScript>();

            eScript.Initialize(this);
        }
    }


    //Si se destruye un enemigo, incrementamos el score

    public void EnemigoDestruido(GameObject enemy)
    {
        //TODO: 
        // Eliminamos la referencia de la lista.
        activeEnemies.Remove(enemy);

        score += 100;

        Debug.Log("Enemigo destruido, score =" + score);
        // Cuando la lista esté vacía,
        if(activeEnemies.Count == 0)
        {
            Debug.Log("RONDA COMPLETADA");
        }
        // hemos terminado la ronda.

        
    }


    //Reiniciar la ronda

    private void ReiniciarEnemigos()
    {
        //TODO: 
        // Primero eliminamos cualquier enemigo
        // que todavía esté vivo.

        // Generamos una nueva oleada.
    }

    // Elminar a todos los enemigos
    private void EliminarEnemigos()
    {
        //TODO: 
        // FOREACH:
        // Queremos hacer la misma operación
        // con todos los enemigos de la lista.

        // Dejamos vacía la lista.

    }
}