using UnityEngine;
using UnityEngine.InputSystem;

public class BeeController : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator animator;
    public float flapStrength = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        RotateBee();
    }

    void MovePlayer()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame || Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            // Reset vertical velocity for consistent flap
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, 0);
            
            // Apply uniform upward force
            rb.AddForce(Vector2.up * flapStrength, ForceMode2D.Impulse);

            animator.SetTrigger("Flap"); // Trigger the flap animation
        }
    }
    void RotateBee()
    {
        float verticalSpeed = rb.linearVelocity.y;
        
        //Clamp for example is score must stay between -45 and 35 degrees, so if the bee is falling too fast, it won't rotate more than -45 degrees
        float angle = Mathf.Clamp(verticalSpeed * 5f, -45f, 35f); // Adjust the multiplier for desired rotation sensitivity
        transform.rotation = Quaternion.Lerp(
            transform.rotation, //where you are
            Quaternion.Euler(0, 0, angle), //where you want to go
            12f * Time.deltaTime //how fast you move there
            //multiply by Time.deltaTime to make it framerate independent
        );
        //ex. Bee jumps = verticalSpeed = 7
        //ex. Bee falls = verticalSpeed = -5
    }

    //Collision2D collision contains information about what you hit
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameManager.gameOver = true; //set the static variable to true, so everyone knows the game is over
        rb.simulated = false; //stop physics for this Rigidbody
    }
}
