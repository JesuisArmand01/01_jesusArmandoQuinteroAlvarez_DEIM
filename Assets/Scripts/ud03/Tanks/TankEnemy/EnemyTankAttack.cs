using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.WSA;

public class EnemyTankAttack : MonoBehaviour
{
    //Zona de variables publicas
    [Header("Time")]
    [SerializeField]
    private float _timer;
    [SerializeField]
    private float _timeBetweenAttacks;
    private bool _isAttack;

    [Header("Audio")]
    [SerializeField]
    private AudioSource _audioSource;
    [SerializeField]
    private AudioClip _shotFiringClip;

    [Header("Prefab")]
    [SerializeField]
    private Rigidbody _shellEnemyPrefab;
    [SerializeField]
    private Transform _posShell;
    [SerializeField]
    private float _launchForce;

    [Header("Raycast")]
    private Ray _ray;
    private RaycastHit _hit;
    [SerializeField]
    private float _distance;

    [SerializeField]
    private float _factorLaunchForce;




    private void Awake()
    {
        _isAttack = false;
        _audioSource = GetComponent<AudioSource>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        if (_isAttack)// _isAttacking significa _isAttacking = true
        {

            Launch();
            //_audioSource.clip = _shotFiringClip;
            //_audioSource.Play();
            _isAttack = false;
        
        }
    }

    // Update is called once per frame
    void Update()
    {

        CountTimer();
        
    }

    private void CountTimer()
    {
        //Creamos el raycast
        _ray.origin = transform.position;
        //indicamos el vector direccion del raycast
        _ray.direction = transform.forward;

        _timer += Time.deltaTime; //_timer = _timer + Time.deltaTime

        if (Physics.Raycast(_ray, out _hit))
        {

            if (_hit.collider.CompareTag("TankPlayer") && _timer >= _timeBetweenAttacks)
            {

                _timer = 0.0f;
                _isAttack = true;
                _distance = _hit.distance;

            }
        }
    
    }

    private void Launch()
    {
        //_audioSource.clip = _shotFiringClip;
        _audioSource.Play();

        float launchForceFinal = _launchForce * _distance * _factorLaunchForce;

        //instanciación de la bala enemiga
        Rigidbody cloneShellPrefab = Instantiate(_shellEnemyPrefab, _posShell.position, _posShell.rotation);
        
        //lanzamiento de la bala enemiga
        cloneShellPrefab.velocity = _posShell.forward * launchForceFinal;

    }
}
