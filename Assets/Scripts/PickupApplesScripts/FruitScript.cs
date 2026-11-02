using UnityEngine;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

public class FruitScript : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float gravity;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*
         * Si usamos rigidBody (motor de fisicas) no podemos usar esto.
        speed += gravity * Time.deltaTime;

        transform.position += Vector3.down * speed; //Aqui usamos Vector3.down para simular la graveda, es decir, que vaya hacia abajo.
        */
    }
}
