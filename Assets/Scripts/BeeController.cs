using UnityEngine;
using UnityEngine.InputSystem;

public class BeeController : MonoBehaviour
{
    Rigidbody2D rb;
    public float flapStrength = 5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame || Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            // Reset vertical velocity for consistent flap
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, 0);
            
            // Apply uniform upward force
            rb.AddForce(Vector2.up * flapStrength, ForceMode2D.Impulse);
        }
        
    }
}
