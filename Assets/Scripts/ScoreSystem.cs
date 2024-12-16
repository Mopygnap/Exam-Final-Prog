using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{
    
    public static ScoreSystem Instance { get; private set; }

    
    private int energy;
    private int collisions;
    private int remainingWalls;
    private int score;
    public Text scoreText;
    private const int MaxEnergy = 1000;
    private const int MinEnergy = 0;

    private void Awake()
    {
        
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);

        energy = MaxEnergy;
        collisions = 0;
        remainingWalls = 0;
        score = 0;
    }

    public void ReduceEnergy(int amount)
    {
        energy = Mathf.Clamp(energy - amount, MinEnergy, MaxEnergy);
        UpdateScore();
        Debug.Log($"Energy reduced. Current energy: {energy}");
    }

    public void AddCollision()
    {
        collisions++;
        ReduceEnergy(10); 
        UpdateScore();
        Debug.Log($"Collision added. Total collisions: {collisions}");
    }

    public void SetRemainingWalls(int count)
    {
        remainingWalls = count;
        UpdateScore();
        Debug.Log($"Remaining walls set to: {remainingWalls}");
    }

    
    public void ReduceRemainingWalls()
    {
        if (remainingWalls > 0)
        {
            remainingWalls--;
            UpdateScore();
            Debug.Log($"Wall destroyed. Remaining walls: {remainingWalls}");
        }
        else
        {
            Debug.Log("No remaining walls to destroy.");
        }
    }

   
    private void UpdateScore()
    {
        score = (energy - collisions) + remainingWalls;
        DisplayScore();
    }

    
    private void DisplayScore()
    {
        if (scoreText != null)
        {
            scoreText.text = $"Score: {score}";
        }
        Debug.Log($"Score updated. Current score: {score}");
    }

    
    public int GetEnergy() => energy;
    public int GetCollisions() => collisions;
    public int GetRemainingWalls() => remainingWalls;
    public int GetScore() => score;

    
    public void DisplayStats()
    {
        Debug.Log($"Energy: {energy}, Collisions: {collisions}, Remaining Walls: {remainingWalls}, Score: {score}");
    }
}
