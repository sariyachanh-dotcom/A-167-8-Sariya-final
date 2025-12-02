using UnityEngine;


public class PlayerMovement : MonoBehaviour

{

    public float moveSpeed = 5f;

    public float jumpForce = 7f;

    private Rigidbody2D rb;

    private bool isGrounded = true;

    void Start()

    {

        rb = GetComponent<Rigidbody2D>();

    }

    void Update()

    {

       

        float move = Input.GetAxisRaw("Horizontal");

        rb.linearVelocity = new Vector2(move * moveSpeed, rb.linearVelocity.y);

       

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)

        {

            rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);

            isGrounded = false;

        }

    }


    private void OnCollisionEnter2D(Collision2D collision)

    {

        if (collision.gameObject.CompareTag("Ground"))

        {

            isGrounded = true;

        }

    }

}
