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


        //Creación de bucle
        while (i < 101)
        {
            
            //Condición, operador de módulo igual a 0
            if (i % 2 == 0)
            {

                //Mostramos por consola resultado de la condición.
                Debug.Log(i);

            }

            i++;
        }


    }
}
