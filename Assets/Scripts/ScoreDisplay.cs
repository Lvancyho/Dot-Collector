using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour, IScoreObserver
{
    public Text scoreText; // Drag and drop your UI Text component here
    private int currentScore;

    private void Start()
    {
        ScoreObserver scoreObserver = FindObjectOfType<ScoreObserver>();
        scoreObserver.AddObserver(this); // Subscribe to score updates
        UpdateScore(0); // Initialize display
    }

    public void UpdateScore(int newScore)
    {
        currentScore = newScore;
        scoreText.text = "Score: " + currentScore; // Update UI Text
    }
}
