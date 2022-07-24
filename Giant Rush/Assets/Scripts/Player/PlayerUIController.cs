using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerUIController : MonoBehaviour
{
    [SerializeField] private PlayerDataTransmitter playerDataTransmitter;
    [SerializeField] private TMP_Text levelText;

    void Update()
    {
        SetLevelText();

    }
    private void SetLevelText()
    {
        levelText.text = playerDataTransmitter.playerLevel.ToString();
    }
}
