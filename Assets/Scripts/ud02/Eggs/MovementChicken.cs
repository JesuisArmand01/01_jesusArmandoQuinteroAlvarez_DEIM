using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementChicken : MonoBehaviour
{

    //zonas de variables globales
    private float _horizontal;
    private float _vertical;

    private float _speed = 2.0f,
                  _turnSpeed = 90.0F;

    // Update is called once per frame
    void Update()
    {

        InputChicken();
        
    }

    private void InputChicken() 
    {

        //Crear guardar/activar input en teclas A y D o < y >
        _horizontal = Input.GetAxis("Horizontal");
        //Crear/activar input en teclas W y S o arriba y abajo
        _vertical = Input.GetAxis("Vertical");


        //Acción vertical, hacia adelante, neutro o hacia atrás
        transform.Translate(Vector3.forward * _vertical * _speed * Time.deltaTime);

        transform.Rotate(Vector3.up * _horizontal * _turnSpeed * Time.deltaTime);

    
    }
}
