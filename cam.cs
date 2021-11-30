using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    Rigidbody2D cameraRigidbody;

    // Hedef
    public Transform targetTransform;

    // Degistirebilir
    public Vector3 cameraPositionOffset;
    public float cameraSpeed;

    void Start()
    {
        cameraRigidbody = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        // Kamera hareket
        cameraRigidbody.AddRelativeForce((targetTransform.position - transform.position) * cameraSpeed, ForceMode2D.Force);
    }
}