using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Even : MonoBehaviour
{

    //Variables globales

    // Start is called before the first frame update
    void Start()
    {
        
        GetEvenNumbers();

    }


    private void GetEvenNumbers()
    {

        //Variables locales
        int i = 0;


        //Creaci�n de bucle
        while (i < 101)
        {
            
            //Condici�n, operador de m�dulo igual a 0
            if (i % 2 == 0)
            {

                //Mostramos por consola resultado de la condici�n.
                Debug.Log(i);

            }

            i++;
        }


    }
}
