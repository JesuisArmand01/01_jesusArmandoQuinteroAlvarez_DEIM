using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class TankPlayerHelath : MonoBehaviour
{
    //Zona de variables globales
    [Header ("Health")]
    [SerializeField]
    private float _maxHealth;
    [SerializeField]
    private float _currentHealth;
    [SerializeField]
    private float _damageEnemyShell;

    [Header("ProgressBar")]
    [SerializeField]
    private Image _lifeBar;

    [Header("GameOver")]
    [SerializeField]
    private GameManagerTanks _gameManager;

    private void Awake()
    {
        _currentHealth = _maxHealth;
        _lifeBar.fillAmount = 1.0f;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider infoAccess)
    {

        if (infoAccess.CompareTag("EnemyShell"))
        {
            //_currentHealth = _curretHealth - _damageEnemyShell
            _currentHealth -= _damageEnemyShell;
            //Le estamos diciendo que rellene el life bar hasta el punto que decimos
            _lifeBar.fillAmount = _currentHealth / _maxHealth;
            //indicamos que destruya el elemento que colisionó con nosotros
            Destroy(infoAccess.gameObject);

            if(_currentHealth <= 0.0f)
            {
                Camera.main.transform.SetParent(null);
                Death();

            }
        
        }
              
    }

    private void Death()
    {
        _gameManager.GameOver();
        Destroy(gameObject);

    }
}
