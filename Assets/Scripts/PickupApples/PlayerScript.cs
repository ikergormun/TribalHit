using UnityEngine;

public class PlayerScript : MonoBehaviour
{

    [SerializeField] private float speed;
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

    }
}
