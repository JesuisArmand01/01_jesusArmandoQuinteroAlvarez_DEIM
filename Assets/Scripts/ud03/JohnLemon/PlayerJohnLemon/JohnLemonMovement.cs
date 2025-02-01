using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class JohnLemonMovement : MonoBehaviour
{
    //Zona de variables globales
    [Header("Movement")]
    [SerializeField]
    private float _speed,
                  _turnSpeed;
                   
    [SerializeField]
    private Vector3 _direction;

    private Rigidbody _rb;
    private Animator _anim;
    private AudioSource _audioSource;

    private float _horizontal,
                  _vertical;

    void Awake()
    {

        _rb = GetComponent<Rigidbody>();
        _anim = GetComponent<Animator>();
        _audioSource = GetComponent<AudioSource>();

    }

    private void FixedUpdate()
    {

        Rotation();

    }

    private void OnAnimatorMove()
    {

        _rb.MovePosition(transform.position + (_direction * _speed * Time.deltaTime));

    }

    // Update is called once per frame
    void Update()
    {

        InputsPlayer();
        IsAnimate();
        AudioSteps();

    }

    private void InputsPlayer()
    {

        //Aqui tenemos la entrada de A y D, o < y >
        _horizontal = Input.GetAxis("Horizontal");
        //Aqui tenemos la entrada de W y S o \/ y /\
        _vertical = Input.GetAxis("Vertical");
        //Aqui tenemos al vector dirección, donde guardamos la dirección para el rigidbody
        _direction = new Vector3(_horizontal, 0.0f, _vertical);
        //Normalizamos el vector _direction
        _direction.Normalize();

    }

    private void IsAnimate()
    {
        if (_horizontal != 0.0F || _vertical != 0.0f)
        {

            _anim.SetBool("IsWalking", true);

        }
        else
        {

            _anim.SetBool("IsWalking", false);
        
        }
        
    }

    private void Rotation()
    {

        Vector3 desiredForward = Vector3.RotateTowards(transform.forward, _direction, _turnSpeed * Time.deltaTime, 0.0f);
        Quaternion rotation = Quaternion.LookRotation(desiredForward);
        _rb.MoveRotation(rotation);
    
    }

    private void AudioSteps()
    {

        if (_horizontal != 0.0f || _vertical != 0.0f)
        {

            if (_audioSource.isPlaying == false)
            {

                _audioSource.Play();

            }

        }
        else
        {

            _audioSource.Stop();
        
        }
    
    }

}
