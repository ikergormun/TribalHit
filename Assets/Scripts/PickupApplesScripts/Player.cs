using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal"); // -1 a 1

        transform.position += Vector3.right * horizontal * speed * Time.deltaTime; //transformo la posicion del personaje con un Vector3 (right), el imput horizontal, la velocidad
        //                                                                           y time.deltatime para que vaya con los fps. Vector3.right es (1,0,0) y horizontal va desde -1 a 1.
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("He detectado una interacción.");

        //Eliminar la fruta
        if(collision.gameObject.tag == "Fruit")
        {
            Debug.Log("Es una piña.");
            Rigidbody2D rb = collision.gameObject.GetComponent<Rigidbody2D>(); //accedemos al rigidbody de la piña

            // rb.linearVelocityY = 0f;

            rb.AddForce(Vector3.up * 10f, ForceMode2D.Impulse);

            //Destroy(collision.gameObject); (si quiero destruir la fruta)
        }

    }
}
