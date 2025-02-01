using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowJohnLemon : MonoBehaviour
{

    //zona de variables globales
    public Transform target;

    [Header("Vectors")]
    [SerializeField]
    private Vector3 _offset;
    [SerializeField]
    private float _smoothing;


    // Start is called before the first frame update
    void Start()
    {

        //calculamos la distancia de la camara a la posición del "target"
        _offset = transform.position - target.position;

    }

    // Update is called once per frame
    void LateUpdate()
    {

        //Creamos un vector3 vacio en donde guardaremos la posición de nuestro "target" sumandole el offset
        Vector3 desiredPosition = target.position + _offset;
        //Nueva posición que es igual al vector entre la posicion anterior de la camara, la nueva y con una interpolación
        transform.position = Vector3.Lerp(transform.position, desiredPosition, _smoothing * Time.deltaTime);

    }
}
