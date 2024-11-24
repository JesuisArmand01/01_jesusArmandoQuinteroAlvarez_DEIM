using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPlayer : MonoBehaviour
{
    //zonas de variables globales
    private float _horizontal;
    private float _vertical;

    private float _speed = 2.0f,
                  _turnSpeed = 90.0F;

    private Animator _anim;
    private Rigidbody _rb;

    private Ray _ray;
    private RaycastHit _hit;
    private bool _isGrounded,
                 _canPlayerJump;

    [Header("Raycast")]
    //Capa en donde quiero que actue el "Raycast"
    public LayerMask GroundMask;

    //Longitud del "Raycast"
    public float RayLength;

    [Header("Jump")]
    //Fuerza de salto
    public float JumpForce;



    private void Awake()
    {
        //variable "_anim" me enlaza este script con el animator controller
        _anim = GetComponent<Animator>();
        //Llamamos al rigidbody asosiado a este script
        _rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {

        InputPlayer();
        MovePlayer();
        TurnPlayer();
        Animating();
        CanJump();

    }

    private void FixedUpdate()
    {

        LaunchRaycast();
        if (_canPlayerJump)
        {

            _canPlayerJump = false;
            //Llamamos al método "Jump"
            Jump();
        
        }

    }

    private void LaunchRaycast() 
    {

        //Establecemos el punto de origen del raycast en el transform position del game object
        _ray.origin = transform.position;
        //Establecemos la dirección del raycast hacia abajo
        _ray.direction = -transform.up;


        if (Physics.Raycast(_ray, out _hit, RayLength))
        {

            //Si la condición se cumple, puedo saltar
            _isGrounded = true;
            Debug.Log("Estoy tocando suelo");
        
        }
        else 
        {

            _isGrounded = false;
        
        }
    
    }

    private void CanJump()
    {

        //Si quiero y puedo saltar
        if (Input.GetKeyDown(KeyCode.Space) && _isGrounded == true)
        {

            _canPlayerJump = true;
        
        }
    
    }

    private void Jump()
    {

        _rb.AddForce(Vector3.up * JumpForce);
    
    }

    private void InputPlayer()
    {

        //Crear guardar/activar input en teclas A y D o < y >
        _horizontal = Input.GetAxis("Horizontal");
        //Crear/activar input en teclas W y S o arriba y abajo
        _vertical = Input.GetAxis("Vertical");

    }

    private void MovePlayer()
    {

        //Acción vertical, hacia adelante, neutro o hacia atrás
        transform.Translate(Vector3.forward * _vertical * _speed * Time.deltaTime);

    }

    private void TurnPlayer()
    {

        //Acción horizontal, hacia la izquierda o hacia la derecha
        transform.Rotate(Vector3.up * _horizontal * _turnSpeed * Time.deltaTime);

    }

    private void Animating()
    {

        //si la variable es distinta de 0 IsMoving
        if (_vertical != 0)
        {

            _anim.SetBool("IsMoving", true);

        }
        else//_vertical es 0, por lo que el Player esta parado
        {

            _anim.SetBool("IsMoving", false);
        
        }


        //Vincular el salto del "PlayerWolf" con la animación
        if (_canPlayerJump == true)
        {

            _anim.SetTrigger("IsJumping");

        }
        
        

    }



}
