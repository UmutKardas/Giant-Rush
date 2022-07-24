using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputController : MonoBehaviour
{
    public float mouseX;

    void Update()
    {
        PlayerXTouch();
    }

    private void PlayerXTouch()
    {
        if (Input.GetMouseButton(0))
        {
            mouseX = Input.GetAxis("Mouse X");
        }
        else
        {
            mouseX = 0;
        }
    }
}
