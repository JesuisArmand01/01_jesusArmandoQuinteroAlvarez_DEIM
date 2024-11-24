using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DescendingOrder : MonoBehaviour
{
    //Variables globales
    public int NumberOne,
               NumberTwo,
               NumberThree;

    // Start is called before the first frame update
    void Start()
    {

        IsDescending();

    }

    private void IsDescending()
    {

        if (NumberOne > NumberTwo && NumberTwo > NumberThree)
        {

            Debug.Log("Los números fueron introducidos en orden descendente.");

        }
        else
        {

            Debug.Log("Los números fueron introducidos en orden incorrecto, por favor, recolocalos de forma descendente.");

        }


    }


}
