using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraMain : MonoBehaviour
{
    [SerializeField] private Transform jugador; 
    [SerializeField] private KeyCode tecla;
    private float rotacion_x, rotacion_y;
    [SerializeField] private float sensibilidad;
    void LateUpdate()
    {
        transform.position = new Vector3(jugador.position.x, jugador.position.y, transform.position.z);
    }
    private void Update()
    {
       if(Input.GetKey(tecla))
        {
                transform.Rotate(rotacion_x, rotacion_y, Input.GetAxis("Mouse X") * sensibilidad);
            }
    }
}
