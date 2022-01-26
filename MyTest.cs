using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyTest : MonoBehaviour
{
    MyVector a = new MyVector(2, -1);
    MyVector b = new MyVector(4, -1);
   
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log(a.ToString());
        ////a.Suma(b);
        //Debug.Log(a.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        a.Draw();
        b.Draw();
    }
}
