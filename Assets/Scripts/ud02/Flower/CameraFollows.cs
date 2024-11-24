using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollows : MonoBehaviour
{

    //Zonas de variables globales
    public Transform Target;

    //Velocidad del movimiento de seguimiento de la cámara
    private float _smoothing;

    //Distancia inicial entre "target" y camara
    private Vector3 _offset;

    // Start is called before the first frame update
    void Start()
    {

        //Distancia entre posicion de la camara y el "target"
        _offset = transform.position - Target.position;
        _smoothing = 1.5f;

    }

    // Update is called once per frame
    void Update()
    {

        //La posición en que quiero que este la camara
        Vector3 camPosition = Target.position + _offset;
        transform.position = Vector3.Lerp (transform.position, camPosition, _smoothing * Time.deltaTime);

    }
}
