using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Addition : MonoBehaviour
{
    //Variables globales
    public int Number;
    private int checkAddition;


    // Start is called before the first frame update
    void Start()
    {
        //Declaramos método de la Adición como tal
        GetAddition();
        //Declaramos método como chequeo de que el valor sea el correcto (me sirvió mientras hacia el ejercicio)
        //GetCheckAddition();

    }

    private void GetCheckAddition() 
    {

        //Variables locales
        int checkAddition;

        //Confirmar resultado correcto operación del "for" a través de fórmula
        checkAddition = (Number * (Number - 1)) / 2;
        Debug.Log(checkAddition);

    }

    private void GetAddition() 
    {

        //Variables locales
        int addition = 0;

        for (int i = 1; i < Number; i++) 
        {
            //Simplificación de la operación: addition = adition + 1
            addition += i;
        
        }

        //Mostrar por consola el resultado buscado
        Debug.Log(addition);
    
    }

}
