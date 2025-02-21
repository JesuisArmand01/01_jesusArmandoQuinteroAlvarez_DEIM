using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    //Zona de variables globales
    [Header("Health")]
    [SerializeField]
    private float _maxHealth;
    [SerializeField]
    private float _currentHealth;
    [SerializeField]
    private float _damageShell;

    [Header("ProgressBar")]
    [SerializeField]
    private Image _lifeBar;


    private void Awake()
    {

        _currentHealth = _maxHealth;
        _lifeBar.fillAmount = 1.0f;

    }

    private void OnTriggerEnter(Collider infoAccess)
    {

        if (infoAccess.CompareTag("PlayerShell"))
        {

            _currentHealth -= _damageShell;
            _lifeBar.fillAmount = _currentHealth / _maxHealth;
            Destroy(infoAccess.gameObject);

            if(_currentHealth <= 0.0f)
            {

                Death();

            }

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Death()
    {

        Destroy(gameObject);

    }
}
