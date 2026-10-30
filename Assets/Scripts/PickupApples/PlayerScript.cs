using UnityEngine;

public class PlayerScript : MonoBehaviour
{

    [SerializeField] private float speed;

    // Límites de la pantalla
    private float minX = -3.5f;
    private float maxX = 3.5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Implementar el movimiento horizontal
        //TO DO
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            //Otra opcion: transform.position -= Vector3.right * speed * Time.deltaTime;
            transform.position += Vector3.left * speed * Time.deltaTime;
        }

        //Limitar posición
        // Si se pasa por la izquierda, lo frenamos en el límite
        if(transform.position.x < minX)
        {
            transform.position = new Vector3(minX, transform.position.y, transform.position.z);
        }

        // Si se pasa por la derecha, lo frenamos en el límite
        if(transform.position.x > maxX)
        {
            transform.position = new Vector3(maxX, transform.position.y, transform.position.z);
        }

        //Version con clamp.
        // Obtenemos la posición actual, modificamos la X y la volvemos a asignar
        //      Vector3 clampedPosition = transform.position; //Guardamos la posicion en una variable temporal
        //
        //      //Cogemos la coordenada x de la variable temporal y aplicamos mathf.clamp con el minimo y el maximo
        //      clampedPosition.x = Mathf.Clamp(clampedPosition.x, minX, maxX);
        //
        //      transform.position = clampedPosition; //Aplicamos la transformacion guardada en la variable temporal.
    }
}
