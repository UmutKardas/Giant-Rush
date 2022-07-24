using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColorController : MonoBehaviour
{
    [SerializeField] private Material playerMaterial;

    public float randomColorNumber;
    [SerializeField] private Color yellowColor;
    [SerializeField] private Color greenColor;
    [SerializeField] private Color orangeColor;


    void Start()
    {
        SetPlayerRandomColor();


    }

    private void SetPlayerRandomColor()
    {
        randomColorNumber = Random.Range(0, 3);
        if (randomColorNumber == 0)
        {
            playerMaterial.color = yellowColor;
            gameObject.tag = "Yellow";
        }
        else if (randomColorNumber == 1)
        {
            playerMaterial.color = greenColor;
            gameObject.tag = "Green";
        }
        else if (randomColorNumber == 2)
        {
            playerMaterial.color = orangeColor;
            gameObject.tag = "Orange";
        }
    }
}
