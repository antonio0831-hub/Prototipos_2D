using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float velocity = 5f;
    private Rigidbody2D rb;
    private Vector2 playerPosition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        playerPosition = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        playerPosition = transform.TransformDirection(playerPosition);
    }
    private void FixedUpdate()
    {
        rb.linearVelocity = playerPosition * velocity;
    }
}
