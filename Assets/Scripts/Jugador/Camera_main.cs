using UnityEngine;

public class Camera_main : MonoBehaviour
{
    [SerializeField] private Transform jugador; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created


    // Update is called once per frame
    void  LateUpdate()
    {
        transform.position = new Vector3(jugador.position.x, jugador.position.y, transform.position.z);
    }
}
