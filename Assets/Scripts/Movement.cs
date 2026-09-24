using UnityEngine;

public class Movement : MonoBehaviour
{
    public float velocidad = 5f;
    private Rigidbody2D rigidbody;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("horizontal");
        float vertical = Input.GetAxis("Vertical");
        transform.position = new Vector2(horizontal,vertical);
    }
}
