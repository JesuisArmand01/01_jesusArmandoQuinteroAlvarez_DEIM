using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Odd : MonoBehaviour
{

    //Variables globales

    // Start is called before the first frame update
    void Start()
    {

        GetOddNumbers();
        
    }

    private void GetOddNumbers() 
    {

        //Variables locales
        int i = 0;


        //Creación de bucle
        while (i < 101)
        {

            //Creamos con "if" la condicion de que el operador de módulo sea igual a 1
            if (i % 2 == 1) 
            {
                //Mostramos por consola los posibles resultados bajo la condición
                Debug.Log(i);
            
            }
         
            i++;
        }

    
    }
}
