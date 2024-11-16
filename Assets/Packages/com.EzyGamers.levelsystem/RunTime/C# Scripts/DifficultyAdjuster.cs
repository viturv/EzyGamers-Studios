using UnityEngine;
using UnityEngine.Rendering.VirtualTexturing;

public class DifficultyAdjuster : MonoBehaviour
{
    public XpSystem xpSystem;  // Reference to XP system

    public enum Difficulty { Easy, Medium, Hard }
    public Difficulty currentDifficulty;

    void Start()
    {
        AdjustDifficulty();
    }

    void Update()
    {
        // Continuously check if the difficulty needs to be updated
        AdjustDifficulty();
    }

    public void AdjustDifficulty()
    {
        if (xpSystem.CurrentLevel <= 5)
        {
            currentDifficulty = Difficulty.Easy;
        }
        else if (xpSystem.CurrentLevel <= 10)
        {
            currentDifficulty = Difficulty.Medium;
        }
        else
        {
            currentDifficulty = Difficulty.Hard;
        }

        // Apply the difficulty changes based on the difficulty level
        ApplyDifficulty();
    }

    public void ApplyDifficulty()
    {
        switch (currentDifficulty)
        {
            case Difficulty.Easy:
                Debug.Log("Current Difficulty: Easy");
                break;

            case Difficulty.Medium:
                Debug.Log("Current Difficulty: Medium");
                break;

            case Difficulty.Hard:
                Debug.Log("Current Difficulty: Hard");
                break;
        }
    }

}

