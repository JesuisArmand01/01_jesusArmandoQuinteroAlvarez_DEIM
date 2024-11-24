using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplesOfThree : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        GetMultiplesThree();


    }

    private void GetMultiplesThree()
    {

        //Variables locales
        int i = 0;


        //Creación de bucle "while"
        while (i < 101)
        {

            //Creación de condición con "if", donde buscamos el operador de módulo sea igual a cero
            if (i % 3 == 0)
            {

                //Mostramos por consola todos los números factibles para este ejercicio
                Debug.Log(i);

            }

            i++;
        }


    }
}
