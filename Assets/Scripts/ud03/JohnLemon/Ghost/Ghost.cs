using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour
{
    //Zona de variables locales
    [Header("WayPoints")]
    [SerializeField]
    private Transform[] _positionsArray;
    [SerializeField]
    private float _speed;
    [SerializeField]
    private Vector3 _posToGo;
    [SerializeField]
    private int _i;

    [Header("Raycast")]
    private Ray _ray;
    private RaycastHit _hit;

    public GameManager GameManagerScript;


    // Start is called before the first frame update
    void Start()
    {

        _i = 0;
        _posToGo = _positionsArray[_i].position;

    }

    private void FixedUpdate()
    {

        DetectionJohnLemon();

    }

    // Update is called once per frame
    void Update()
    {

        Move();
        ChangePosition();
        Rotate();

    }

    private void Move()
    {

        //Movimiento "Towards" = Hacia, la posicion que estas, la posicion que vas y su velocidad
        transform.position = Vector3.MoveTowards(transform.position, _posToGo, _speed * Time.deltaTime);

    }

    private void ChangePosition()
    {
        //EN este condicional estas comparando la distancia del fantasma con la distancia objetivo,
        //esperando a que sea practicamente 0
        if (Vector3.Distance(transform.position, _posToGo) <= Mathf.Epsilon)
        {
            //Si la posición del array es la ultima, comienza a contar desde el primer elemento
            if (_i == _positionsArray.Length - 1)
            {

                _i = 0;
            
            }
            else //sino suma +1
            {

                _i++;
            
            }

            //Actualizamos la posicion deseada
            _posToGo = _positionsArray[_i].position;
        
        }
    
    }

    private void Rotate()
    {

        //Simplemente hacemos que el fantasma mire siempre al punto al que se dirige
        transform.LookAt(_posToGo);
    
    }

    private void DetectionJohnLemon()
    {

        //Modificamos el origen del ray, emitiendo en el eje Y un metro encima
        _ray.origin = new Vector3(transform.position.x, transform.position.y + 1, transform.position.z);
        //ahora hay que decir en que sentido lo tiene que dirigir
        _ray.direction = transform.forward;

        //luego tenemos que hacer que la info del Hit salga para poder hacer el debug
        if (Physics.Raycast(_ray, out _hit))
        {

            //ahora hacemos el debug cuando choca con el tag
            if (_hit.collider.CompareTag("JohnLemon"))
            {

                Debug.Log("Booooo, te he pillaooooo");
                GameManagerScript.IsPlayerCaught = true;

            }
        
        }
        
    }

}
