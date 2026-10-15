using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;


public class CameraMain : MonoBehaviour
{
    [SerializeField] private KeyCode keyboardKey;
    [SerializeField] private float mouseSensitivity;
    private float rotation_x, rotation_y;
    [SerializeField] private Rigidbody2D playerRigidBody2D;
    private float cameraAngle;
    private void Update()
    {
        if (Input.GetKey(keyboardKey))
        {
            CameraRotate();
        }
      
            
    }

    void CameraRotate()
    {
        cameraAngle += Input.GetAxis("Mouse X") * mouseSensitivity;
        transform.Rotate(rotation_x, rotation_y, Input.GetAxis("Mouse X") * mouseSensitivity);
        PlayerRotate();
    }

    private void PlayerRotate()
    {
     playerRigidBody2D.MoveRotation(cameraAngle);
    }
}

