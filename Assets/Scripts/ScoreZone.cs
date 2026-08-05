using UnityEngine;

public class ScoreZone : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Collision2D collision contains information about what you hit
    private void OnTriggerEnter2D(Collider2D collision)
    {
    //if the object entering is the Player
     if (collision.CompareTag("Player"))
        {
            GameManager.score++;
        }   
    }
}
