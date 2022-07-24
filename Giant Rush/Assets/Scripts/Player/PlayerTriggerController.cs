using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTriggerController : MonoBehaviour
{
    [SerializeField] private PlayerDataTransmitter playerDataTransmitter;
    private float playerScaleAmount;

    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.tag == other.gameObject.tag)
        {
            playerDataTransmitter.PlayerScaleIncrease();
            playerDataTransmitter.playerLevel++;
            Destroy(other.gameObject);
        }
        else
        {
            playerDataTransmitter.PlayerScaleDeacrease();
            playerDataTransmitter.playerLevel--;
            Destroy(other.gameObject);
        }

    }
}
