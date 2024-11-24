using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloneEggs : MonoBehaviour
{

    //Zona de variables globales
    public GameObject EggModel;
    public Transform PosRotEggs;

    
    // Update is called once per frame
    void Update()
    {
        //Método creador de "Eggs"
        CreateEggs();

    }

    private void CreateEggs() 
    {

        if (Input.GetMouseButtonDown(0))
        {
            //Crear clones de el "EggModel" prefabricado, identificando todos los clones bajo el nombre "cloneEggs"
            GameObject cloneEggs = Instantiate(EggModel, PosRotEggs.position, PosRotEggs.rotation);

            //Pedimos y nombramos el "Rigidbody" de los clones de "Eggs"
            Rigidbody rbCloneEggs = cloneEggs.GetComponent<Rigidbody>();

            //"Thrust Z", fuerza para lanzar un poco mas lejos los huevos


        }
    
    }

}
