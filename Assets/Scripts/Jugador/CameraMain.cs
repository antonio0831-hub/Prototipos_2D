using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraMain : MonoBehaviour
{
    [SerializeField] private KeyCode keyboardKey;
    [SerializeField] private float mouseSensitivity;
    private float rotation_x, rotation_y;
    private void Update()
    {
        if (Input.GetKey(keyboardKey))
        {
            CameraRotate();
        }
      
            
    }

    void CameraRotate()
    {
        transform.Rotate(rotation_x, rotation_y, Input.GetAxis("Mouse X") * mouseSensitivity);
    }
}

