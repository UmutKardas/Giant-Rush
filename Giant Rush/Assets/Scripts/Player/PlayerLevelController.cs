using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLevelController : MonoBehaviour
{
    [SerializeField] private PlayerDataTransmitter playerDataTransmitter;


    void Update()
    {
        LevelController();

    }
    private void LevelController()
    {
        if (playerDataTransmitter.playerLevel == 0)
        {
            SceneManager.LoadScene(0);
        }
    }
}
