using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyTankMovement : MonoBehaviour
{
    //Zonas de variables globales
    [SerializeField]
    private GameObject _player;

    private NavMeshAgent _agent;

    [SerializeField]
    private AudioClip _engineDrivingClip;
    [SerializeField]
    private AudioClip _engineIdleClip;
    [SerializeField]
    private AudioSource _audioSource;


    private void Awake()
    {
        _player = GameObject.FindGameObjectWithTag("TankPlayer");
        _agent = GetComponent<NavMeshAgent>();
        _audioSource = GetComponent<AudioSource>(); 
        
    }

    // Start is called before the first frame update
    void Start()
    {

        if(_player != null)
        {
            _audioSource.clip = _engineDrivingClip;
            _audioSource.Play();
        }
        else
        {
            _audioSource.clip = _engineIdleClip;
            _audioSource.Play();
        }
        

    }

    // Update is called once per frame
    void Update()
    {

        if (_player == null)
        {

            return;

        }

        GetPlayer();
        

    }

    private void GetPlayer()
    {

        _agent.SetDestination(_player.transform.position);
        
    }
}
