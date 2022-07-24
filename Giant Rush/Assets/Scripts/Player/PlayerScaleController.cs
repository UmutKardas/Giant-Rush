using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScaleController : MonoBehaviour
{
    private float playerScaleAmount;

    public void PlayerScaleIncrease()
    {
        playerScaleAmount += 0.1f;
        gameObject.transform.localScale = new Vector3(transform.localScale.x + playerScaleAmount,
        transform.localScale.y + playerScaleAmount,
        transform.localScale.z + playerScaleAmount);
        playerScaleAmount = 0f;
    }
    public void PlayerScaleDeacrease()
    {
        playerScaleAmount -= 0.1f;
        gameObject.transform.localScale = new Vector3(transform.localScale.x + playerScaleAmount,
        transform.localScale.y + playerScaleAmount,
        transform.localScale.z + playerScaleAmount);
        playerScaleAmount = 0f;
    }
}
