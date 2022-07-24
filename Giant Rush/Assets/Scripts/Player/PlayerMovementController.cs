using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    [SerializeField] private PlayerDataTransmitter playerDataTransmitter;
    Vector3 newPlayerPosition;
    public float playerSpeed;
    public float newX;
    public float speedX;
    public float limitX;


    void Update()
    {
        SetPlayerMovement();
        SetPlayerX();

    }
    private void SetPlayerX()
    {
        newX = transform.position.x + speedX * playerDataTransmitter.PlayerXValues() * Time.deltaTime;
        newX = Mathf.Clamp(newX, -limitX, limitX);

    }

    private void SetPlayerMovement()
    {
        newPlayerPosition = new Vector3(
            newX,
            transform.position.y,
            transform.position.z + playerSpeed * Time.deltaTime
        );

        transform.position = newPlayerPosition;

    }
}
