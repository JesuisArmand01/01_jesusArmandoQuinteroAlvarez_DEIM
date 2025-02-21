using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasEnemy : MonoBehaviour
{
  

    // Update is called once per frame
    void Update()
    {

        //Mirar la barra de vida siempre a la camara
        transform.LookAt(Camera.main.transform.position);
        
    }
}
