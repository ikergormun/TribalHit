using UnityEngine;

public class Orco
{
    public string name;
    public float fuerza;
    public float resistencia;
    public float destreza;
    public float vida;

    public Orco(string n, float f, float r, float d)
    {
        this.name = n;
        this.fuerza = f;
        this.resistencia = r;
        this.destreza = d;

        this.vida = 100 + this.resistencia * 5.0f;

        Defenderse(100);
    }

    public void Atacar(Orco objetivo)
    {
        float daño = CalcularDañoBasico();
        objetivo.RecibirDaño(daño);
        Debug.Log($"{name} ataca a {objetivo.name} e inflige {daño} de daño.");
    }

    public void RecibirDaño(float daño)
    {
        this.vida -= daño;
    }

    public void Gritar()
    {
        Debug.Log($"¡¿Soy {name}!!");
    }
    public float Defenderse(float dañoEntrante)
    {
        float dañoRecibido = 0;

        dañoRecibido = dañoEntrante - resistencia * 1.5f;

        vida -= dañoRecibido;
        if (vida < 0)
        {
            vida = 0;
        }

        Debug.Log("Daño recibido: " + dañoRecibido + ", vida restante: " + vida);

        return dañoRecibido;
    }

    private float CalcularDañoBasico()
    {
        //TODO
        return 0.0f;
    }

    public float getVida()
    {
        return vida;
    }

    public void setVida(float vida)
    {
        this.vida = Mathf.Clamp(vida, 0f, 100f);
    }
}

public class Clases : MonoBehaviour
{
    Orco orc;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        orc = new Orco("Fulano", 7, 5, 1);

        orc.Defenderse(40);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
