using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreasingOrder : MonoBehaviour
{

    //Variables globales
    public int NumberOne,
               NumberTwo,
               NumberThree;

    // Start is called before the first frame update
    void Start()
    {

        IsIncreasing();


    }

    private void IsIncreasing() 
    {

        //Creación del "if"

        if (NumberOne < NumberTwo && NumberTwo < NumberThree) 
        {
            
            //Mostrar por consola el resultado favorable
            Debug.Log("Los números fueron introducidos en orden ascendete.");
        
        }
        else 
        {

            //Mostrar por consola resultado no favorable, pidiendo la correcta introducción de datos
            Debug.Log("Los números fueron introducidos en orden incorrecto, por favor, recolocalos de forma ascendente.");
        
        }

    
    }
}
