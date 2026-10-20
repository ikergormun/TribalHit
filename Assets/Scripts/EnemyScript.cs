using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    //TODO
    private GameManager gameManager;

    public void Initialize(GameManager gameManager)
    {
        this.gameManager = gameManager;
    }

    private void OnMouseDown()
    {
        Debug.Log("Hola");

        gameManager.EnemigoDestruido(gameObject);
        Destroy(gameObject);
    }
}