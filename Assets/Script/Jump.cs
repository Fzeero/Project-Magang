using UnityEngine;

public class Jump : MonoBehaviour
{
    public float jumpForce = 5f; // Kekuatan lompatan
    private Rigidbody2D rb;      // Referensi Rigidbody2D
    private bool isGrounded;     // Cek apakah karakter berada di tanah
    public Transform groundCheck; // Posisi untuk cek tanah
    public float groundCheckRadius = 0.2f; // Radius cek tanah
    public LayerMask groundLayer; // Layer untuk tanah

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // Cek apakah karakter berada di tanah menggunakan OverlapCircle
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);
    }

    public void jump()
    {
        if (isGrounded)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce); // Tambahkan gaya vertikal
        }
    }
}
