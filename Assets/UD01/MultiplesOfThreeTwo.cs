using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplesOfThreeTwo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        GetMultiplesThreeTwo();

    }

    private void GetMultiplesThreeTwo()
    {

        //Variables locales
        int i = 0;


        //Creaci�n de bucle "while"
        while (i < 101)
        {

            //Para la condici�n hacemos dos, que el operador de m�dulo sea igual a cero para 2 y 3 (o ambos)
            if (i % 2 == 0 || i % 3 == 0)
            {
                //Mostramos por consola el resultado de cada n�mero factible
                Debug.Log(i);

            }

            i++;
        }


    }
}
