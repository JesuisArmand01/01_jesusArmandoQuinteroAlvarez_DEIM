using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerTanks : MonoBehaviour
{
    //Zona de variables globales
    [SerializeField]
    private GameObject _panelGameOver;
    [SerializeField]
    private EnemyManager _enemyManager;

    
    public void GameOver()
    {

        //Activamos el panel GameOver
        _panelGameOver.SetActive(true);
        //Desactivamos la creacion automatizada de enemigos
        _enemyManager.enabled = false;

    }

    public void LoadSceneLevel()
    {

        SceneManager.LoadScene(0);

    }

}
