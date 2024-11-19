using UnityEngine;
using TMPro;

public class DifficultyAdjuster : MonoBehaviour
{
    public XpSystem xpSystem; // Reference to the XP system

    public enum Difficulty { Easy, Medium, Hard }
    public Difficulty currentDifficulty;

    public TextMeshProUGUI difficultyText; // Reference to Difficulty UI Text

    void Start()
    {
        if (xpSystem == null)
        {
            Debug.LogError("XpSystem reference is not assigned to DifficultyAdjuster.");
            return;
        }

        // Initialize the difficulty display
        UpdateDifficulty();
    }

    void Update()
    {
        if (xpSystem != null)
        {
            // Continuously check and adjust difficulty based on current XP level
            UpdateDifficulty();
        }
    }

    public void UpdateDifficulty()
    {
        if (xpSystem == null) return;

        Difficulty previousDifficulty = currentDifficulty;

        // Adjust difficulty based on the player's level
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
        UpdateDifficultyText();
        // Update the UI only if the difficulty has changed
        if (currentDifficulty != previousDifficulty)
        {
            UpdateDifficultyText();
        }
    }

    private void UpdateDifficultyText()
    {
        if (difficultyText != null)
        {
            difficultyText.text = $"Current Difficulty: {currentDifficulty}";
        }
        else
        {
            Debug.LogError("DifficultyText is not assigned in the Inspector.");
        }
    }
}
