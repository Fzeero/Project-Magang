using UnityEngine;
using UnityEngine.UI;

public class JumpAndControl : MonoBehaviour
{
    public Button jumpButton;     
    public float jumpForce = 10f; 
    public Transform groundCheck; 
    public float groundCheckRadius = 0.2f; 
    public LayerMask groundLayer; 

    private Rigidbody2D rb;       
    private bool isGrounded = false; 
    private bool isArrowClicked = false; 

    private bool isJumpButtonClicked = false;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        jumpButton.interactable = false; 
    }

    private void Update()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);
    }

    public void OnArrowClick()
    {
        isArrowClicked = true; 
        jumpButton.interactable = true; 
    }

    public void OnJumpClick()
    {
        
        if (isGrounded)
        {
            // Terapkan gaya untuk melompat
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce); 
 
        }
    }

    public void AfterJump()
    {
        if(isJumpButtonClicked)
        {
            isArrowClicked = false;
            jumpButton.interactable = false;
        }
    }

}

