using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //Zona de variables globales
    //Variables para las imagenes relacionadas con UI
    [Header("Images")]
    [SerializeField]
    private Image _caughtImage;
    [SerializeField]
    private Image _wonImage;
    [SerializeField]
    private GameObject _restartPanel;

    //Variables relacionadas con el fade
    [Header("Fade")]
    [SerializeField]
    private float _fadeDuration;
    [SerializeField]
    private float _displayImageDuration;
    private float _timer;

    //Variables booleanas con el Caught, Won y Restart
    public bool IsPlayerAtExit;
    public bool IsPlayerCaught;
    public bool IsRestartLevel;

    //Variables relacionadas con Audio
    [Header("Audio")]
    [SerializeField]
    private AudioClip _caughtClip;
    [SerializeField]
    private AudioClip _wonClip;
    private AudioSource _audioSource;

    private void Awake()
    {
        
        _audioSource = GetComponent<AudioSource>();

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (IsPlayerAtExit)
        {

            Won();

        }
        else if(IsPlayerCaught)
        {

            Caught();
        
        }
        
    }

    private void Won()
    {

        _audioSource.clip = _wonClip;

        if (_audioSource.isPlaying == false)
        {

            _audioSource.Play();
                    
        }

        //aqui decimos que el timer vaya sumando 1 a 1 siguiendo el ritmo de Time.deltaTime
        _timer = _timer + Time.deltaTime;

        //Ahora vamos a hacer que el canal alfa vaya subiendo de 0 a 1 usando el timer
        _wonImage.color = new Color(_wonImage.color.r, _wonImage.color.g, _wonImage.color.b, _timer / _fadeDuration);

        

        if (_timer > _fadeDuration + _displayImageDuration)
        {

            Debug.Log("Has ganao");
            _restartPanel.SetActive(true);

        }
    
    }

    private void Caught()
    {

        _audioSource.clip = _caughtClip;

        if (_audioSource.isPlaying == false)
        {

            _audioSource.Play();

        }

        //aqui decimos que el timer vaya sumando 1 a 1 siguiendo el ritmo de Time.deltaTime
        _timer = _timer + Time.deltaTime;

        //Ahora vamos a hacer que el canal alfa vaya subiendo de 0 a 1 usando el timer
        _caughtImage.color = new Color(_caughtImage.color.r, _caughtImage.color.g, _caughtImage.color.b, _timer / _fadeDuration);

        if (_timer > _fadeDuration + _displayImageDuration)
        {

            Debug.Log("Has perdio");
            SceneManager.LoadScene("JohnLemon");

        }

    }

    private void OnTriggerEnter(Collider infoAccess)
    {

        if (infoAccess.CompareTag("JohnLemon"))
        {

            Debug.Log("OLEEEE, has ganao");
            IsPlayerAtExit = true;
        
        }

    }

    public void LoadSceneRestart()
    {

        SceneManager.LoadScene("JohnLemon");
    
    }

}
