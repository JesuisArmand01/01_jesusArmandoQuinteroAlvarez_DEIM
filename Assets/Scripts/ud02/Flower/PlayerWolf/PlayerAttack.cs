using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{

    //Zona de variables globales
    public GameObject FlowerModel;
    public Transform PosRotFlower;
    private float _thrustY = 100.0f,
                  _thrustZ = 300.0f,
                  _timeDestroyFlower = 4.0f;

    private Animator _anim;

    private void Awake()
    {
        
        //Vinculo entre el script y el "Animator Controller"
        _anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {

        CreateFlowers();
        if (Input.GetMouseButtonDown(0))
        {

            Attack();

        }

    }

    private void CreateFlowers() 
    {

        if (Input.GetMouseButtonDown(0))
        {

            //Nombrar a los clones de la flor con un solo nombre "cloneFlowers"
            GameObject cloneFlowers = Instantiate(FlowerModel, PosRotFlower.position, PosRotFlower.rotation);

            //Llamada al rigidbody de la "FlowerModel"
            Rigidbody rbFlowerModel = cloneFlowers.GetComponent<Rigidbody>();

            //Fuerza hacia arriba de la parabola de tiro, Vector3 hace referencia a el Mundo
            rbFlowerModel.AddForce(Vector3.up * _thrustY);

            //Fuerza hacia adelante de la parabola de tiro, Transform hace referencia al eje Z local
            rbFlowerModel.AddForce(transform.forward * _thrustZ);

            //Destruir flor pasado un tiempo
            Destroy(cloneFlowers, _timeDestroyFlower);

        }
    
    }

    private void Attack()
    {

        //Ejecutar animacion de ataque
        _anim.SetTrigger("IsWaving");

    }
}
