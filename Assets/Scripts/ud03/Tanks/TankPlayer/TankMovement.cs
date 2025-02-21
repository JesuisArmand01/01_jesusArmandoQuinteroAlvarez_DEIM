using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    //Zona de variables globales
    [Header("Movement")]
    [SerializeField]
    private float _speed;
    [SerializeField]
    private float _turnSpeed;
    private float _horizontal,
                  _vertical;
    private Rigidbody _rb;


    [Header("Audio")]
    [SerializeField]
    private AudioClip _idleClip;
    [SerializeField]
    private AudioClip _drivingClip;
    private AudioSource _audioSource;


    private void Awake()
    {
        
        _rb = GetComponent<Rigidbody>();
        _audioSource = GetComponent<AudioSource>();

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void FixedUpdate()
    {

        Move();
        Turn();

    }

    // Update is called once per frame
    void Update()
    {

        InputPlayer();
        AudioPlayer();


    }

    private void InputPlayer()
    {

        _horizontal = Input.GetAxis("Horizontal");
        _vertical = Input.GetAxis("Vertical");
    
    }

    private void Move()
    {
        
        //Creamos un vector de dirección, pues el Rb MovePosition nos pide un vector
        Vector3 direction = transform.forward * _vertical * _speed * Time.deltaTime;

        //Como es un método que funciona con el Rigidbody, llamamos desde el FixedUpdate
        _rb.MovePosition(transform.position + direction);

    }

    private void Turn()
    {

        //creamos un vector3
        float turn = _turnSpeed * _horizontal * Time.deltaTime;

        //Ahora el vector 3 queremos convertirlo en un Quaternion
        Quaternion turnRotation = Quaternion.Euler(0.0f, _horizontal, 0.0f);

        //Movimiento de rotacion usando el Rigidbody, necesitamos un Quaternion
        _rb.MoveRotation(transform.rotation * turnRotation);
    
    }

    private void AudioPlayer()
    {

        if (_vertical != 0.0f || _horizontal != 0.0f)
        {

            if (_audioSource.clip != _drivingClip) //El tanque esta en movimiento
            {

                _audioSource.clip = _drivingClip;
                _audioSource.Play();

            }

        }
        else
        {

            if (_audioSource.clip != _idleClip) //El tanque esta quieto
            {

                _audioSource.clip = _idleClip;
                _audioSource.Play();
            
            } 

        }
    

    }



}
