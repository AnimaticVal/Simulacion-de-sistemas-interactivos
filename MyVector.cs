using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyVector 
{
    public int x;
    public int y;
    public MyVector(int a, int b) 
    {
        x = a;
        y = b;
    
    }

    public void Suma(MyVector vector) 
    {
        x = x + vector.x;
        y = y + vector.y;
    }

    public void Resta(MyVector vector) 
    {
        x = x - vector.x;
        y = y - vector.y;
    }

    public override string ToString()
    {
        return ("(" + x + "," + y + ")");
    }

    public void Draw() {

        Debug.DrawLine(Vector3.zero, new Vector3(x,y));
    }

}
