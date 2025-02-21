using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    //Zona de variables globales
    [Header("Instantiate")]
    [SerializeField]
    private GameObject _enemyTank;
    [SerializeField]
    private Transform[] _posRotEnemy;
    [SerializeField]
    private float _timeBetweenEnemies;


    // Start is called before the first frame update
    void Start()
    {

        InvokeRepeating("CreateEnemies", _timeBetweenEnemies, _timeBetweenEnemies);
        
    }


    private void CreateEnemies()
    {

        int n = Random.Range(0, _posRotEnemy.Length);

        //Instanciación de los enemigos
        Instantiate(_enemyTank, _posRotEnemy[n].position, _posRotEnemy[n].rotation);

    }
}
