using UnityEngine;
using TMPro; //lets us work with TextMeshPro objects
public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText; //reference to the score text object
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject gameOverPanel;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = GameManager.score.ToString();

        if (GameManager.gameOver)
        {
            gameOverPanel.SetActive(true);
        }
    }
}
