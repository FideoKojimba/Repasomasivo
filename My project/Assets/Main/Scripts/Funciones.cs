using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Funciones : MonoBehaviour
{
    private int _numeroEntero = 2;
    // Start is called before the first frame update

    public Clases ListaEstudiantes;
    void Start()
    {
        MyFuncion();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MyFuncion()
    {
        Debug.Log(ListaEstudiantes.estudiantes[2]);
        Debug.Log(ListaEstudiantes.edadEstudiantes[2]);
  
    }


}
