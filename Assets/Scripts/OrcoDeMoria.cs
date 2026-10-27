using UnityEngine;

public class OrcoDeMoria : Orco
{
    private float precisión;
    public OrcoDeMoria(string name, float fuerza, float resistencia, float destreza, float precisión) : base(name, fuerza, resistencia, destreza)
    {
        this.precisión = precisión;
    }

    public void Disparar(Orco objetivo)
    {
        objetivo.RecibirDaño(10f);
    }
}
