using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float velocidad = 5f;
    private Rigidbody2D rb;
    private Vector2 posicion;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        posicion = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    }
    private void FixedUpdate()
    {
        rb.linearVelocity = posicion * velocidad;
    }
}
