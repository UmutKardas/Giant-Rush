using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotateController : MonoBehaviour
{
    [SerializeField] private PlayerDataTransmitter playerDataTransmitter;
    [SerializeField] private float lerpValue;
    void Start()
    {

    }

    void Update()
    {
        SetPlayerRotate();

    }
    private void SetPlayerRotate()
    {
        if (playerDataTransmitter.PlayerXValues() > 0)
        {
            transform.rotation = Quaternion.Slerp
           (transform.rotation, Quaternion.Euler(0, 40f, 0), lerpValue * Time.deltaTime);
        }
        else if (playerDataTransmitter.PlayerXValues() < 0)
        {
            transform.rotation = Quaternion.Slerp
          (transform.rotation, Quaternion.Euler(0, -40f, 0), lerpValue * Time.deltaTime);

        }
        else
        {
            transform.rotation = Quaternion.Slerp
          (transform.rotation, Quaternion.Euler(0, 0, 0), lerpValue * Time.deltaTime);
        }

    }
}
