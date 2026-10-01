using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraMain : MonoBehaviour
{
    [SerializeField] private Transform playerPosition; 
    [SerializeField] private KeyCode keyboardKey;
    private float rotation_x = 0, rotation_y = 0;
    [SerializeField] private float mouseSensitivity;
    void LateUpdate()
    {
        transform.position = new Vector3(playerPosition.position.x, playerPosition.position.y, transform.position.z);
    }
    private void Update()
    {
       if(Input.GetKey(keyboardKey))
        {
                transform.Rotate(rotation_x, rotation_y, Input.GetAxis("Mouse X") * mouseSensitivity);
            }
    }
}
