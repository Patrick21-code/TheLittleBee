using UnityEngine;

public class GameManager : MonoBehaviour
{
    //instead of each object having its own gameOver, everyone checks the same one
    public static bool gameOver = false; //static means there's only one shared value for the entire game
    public static int score = 0;
    //reset the game state when a new game starts
    //unity calls Awake before Start on all active objects in the scene
    void Awake ()
    {
        gameOver = false;
        score = 0;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
