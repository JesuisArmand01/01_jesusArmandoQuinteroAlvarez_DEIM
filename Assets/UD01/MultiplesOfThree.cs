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


        //Creaci�n de bucle "while"
        while (i < 101)
        {

            //Creaci�n de condici�n con "if", donde buscamos el operador de m�dulo sea igual a cero
            if (i % 3 == 0)
            {

                //Mostramos por consola todos los n�meros factibles para este ejercicio
                Debug.Log(i);

            }

            i++;
        }


    }
}
