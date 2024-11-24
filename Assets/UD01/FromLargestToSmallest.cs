using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FromLargestToSmallest : MonoBehaviour
{

    //Variables globales
    public int NumberOne,
               NumberTwo,
               NumberThree;


    // Start is called before the first frame update
    void Start()
    {

        GetOrderNumbers();

    }

    private void GetOrderNumbers() 
    {
        //Creamos un "if, else if",

        if (NumberOne > NumberTwo && NumberTwo > NumberThree)
        {
            Debug.Log("El orden ascendente de los números introducidos es: " + NumberOne + " , " + NumberTwo + " , " + NumberThree + ".");

        }
        else if (NumberTwo > NumberOne && NumberOne > NumberThree)
        {

            Debug.Log("El orden ascendente de los números introducidos es: " + NumberTwo + " , " + NumberOne + " , " + NumberThree + ".");

        }
        else if (NumberTwo > NumberThree && NumberThree > NumberOne)
        {

            Debug.Log("El orden ascendente de los números introducidos es: " + NumberTwo + " , " + NumberThree + " , " + NumberOne + ".");

        }
        else if (NumberThree > NumberTwo && NumberTwo > NumberOne)
        {

            Debug.Log("El orden ascendente de los números introducidos es: " + NumberThree + " , " + NumberTwo + " , " + NumberOne + ".");

        }
        else if (NumberOne > NumberThree && NumberThree > NumberTwo)
        {

            Debug.Log("El orden ascendente de los números introducidos es: " + NumberOne + " , " + NumberThree + " , " + NumberTwo + ".");

        }
        else if (NumberThree > NumberOne && NumberOne > NumberTwo)
        {

            Debug.Log("El orden ascendente de los números introducidos es: " + NumberThree + " , " + NumberOne + " , " + NumberTwo + ".");

        }
        else if (NumberOne == NumberTwo && NumberTwo == NumberThree)
        {

            Debug.Log("Los números introducidos son iguales.");

        }


    }
}
