using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDataTransmitter : MonoBehaviour
{
    [SerializeField] private PlayerInputController playerInputController;
    [SerializeField] private PlayerColorController playerColorController;
    [SerializeField] private PlayerScaleController playerScaleController;

    public int playerLevel = 1;

    public float PlayerXValues()
    {
        return playerInputController.mouseX;
    }

    public float PlayerColorNumber()
    {
        return playerColorController.randomColorNumber;
    }

    public void PlayerScaleIncrease()
    {
        playerScaleController.PlayerScaleIncrease();

    }

    public void PlayerScaleDeacrease()
    {
        playerScaleController.PlayerScaleDeacrease();
    }




}
