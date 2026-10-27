using UnityEngine;

public class MyVector3
{
    private float x;
    private float y;
    private float z;
    private float magnitude;

    //CONSTRUCTOR.
    public MyVector3()
    {
        x = 0f;
        y = 0f;
        z = 0f;
        magnitude = 0f;
    }

    public MyVector3(float x, float y, float z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
        this.magnitude = -1;
    }

    public float Magnitude()
    {
        if(this.magnitude > 0f)
        {
            return this.magnitude;
        }
        else
        {
            this.magnitude = Mathf.Sqrt(x * x + y * y + z * z);

            return magnitude;
        }
    }

    public MyVector3 Add(MyVector3 vec)
    {
        float x3 = this.x + vec.x;
        float y3 = this.y + vec.y;
        float z3 = this.z + vec.z;

        return new MyVector3(x3, y3, z3);
    }

    //Metodo para normalizar un vector
    public void Normalize()
    {
        if(this.magnitude > 0f)
        {
            this.magnitude = Magnitude();
        }

        this.x /= this.magnitude;
        this.y /= this.magnitude;
        this.z /= this.magnitude;

        //Vector3.Normalize(new Vector3(0, 0, 0));

        //Vector3 vec = new Vector3(0, 0, 0);
        //vec.Normalize();

    }
    //Metodo para calcular el producto escalar public MyVector3

    //Metodo para Distance (distancia entre dos vectores)
    //Metodo para Angle (angulo entre dos vectores)
    //Metodo para Dot (
}
