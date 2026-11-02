using UnityEngine;

public class GroundScript : MonoBehaviour
{
    [SerializeField] Transform Spawnpoint;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //metodo que se activa cuando un trigger entra en suelo
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Detectamos si es una fruta

        if(collision.gameObject.tag == "Fruit")
        {
            collision.gameObject.transform.position = Spawnpoint.position; //new Vector3(0, 4, 0);//Movemos la fruta a arriba otra vez
            collision.gameObject.GetComponent<Rigidbody2D>().linearVelocityY = 0f; //Acceso al componente del rigidbody para resetear la caida
        }
    }
}
