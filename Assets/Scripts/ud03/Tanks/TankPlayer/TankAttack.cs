using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankAttack : MonoBehaviour
{
    //zona de variables globales
    [Header("Lanzamiento")]
    [SerializeField]
    private Rigidbody _shellPrefab;
    [SerializeField]
    private Transform _posShell;
    [SerializeField]
    private float _launchForce;

    [Header("Audio Explosion")]
    [SerializeField]
    private AudioSource _audioSource;



    // Update is called once per frame
    void Update()
    {

        InputPlayer();

    }

    private void InputPlayer() //metodo para recooger el input para lanzamiento
    {

        if (Input.GetMouseButtonDown(0))
        {

            Launch();
        
        }

    }

    private void Launch()
    {

        //Instanciamos la bala
        Rigidbody cloneShellPrefab = Instantiate(_shellPrefab, _posShell.position, _posShell.rotation);
        //Audio disparando bala
        _audioSource.Play();

        cloneShellPrefab.velocity = _posShell.forward    * _launchForce;
    
    }

}
