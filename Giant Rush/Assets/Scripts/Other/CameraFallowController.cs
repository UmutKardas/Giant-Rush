using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFallowController : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;
    [SerializeField] private float lerpValue;
    private Vector3 offset;
    private Vector3 newPos;
    void Start()
    {
        offset = transform.position - playerTransform.position;
    }

    void LateUpdate()
    {

        newPos = Vector3.Lerp(transform.position, playerTransform.position + offset, lerpValue);
        transform.position = new Vector3(0f, newPos.y, newPos.z);
    }
}
