using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shell : MonoBehaviour
{
    //Zona de variables globales
    [SerializeField]
    private ParticleSystem _explotionShell;

    private AudioSource _audioSource;

    private Collider _coll;
    private Renderer _rend;

    private void Awake()
    {
        
        _audioSource = GetComponent<AudioSource>();
        _coll = GetComponent<Collider>();
        _rend = GetComponent<Renderer>();

    }



    private void OnTriggerEnter (Collider infoAccess)
    {
        //Aqui estamos eliminando el colisionador y la malla,
        //para evitar que se vea una vez explote
        _coll.enabled = false;
        _rend.enabled = false;

        _explotionShell.Play();
        _audioSource.Play();
        Destroy(gameObject, 1.0f);

    }
}
