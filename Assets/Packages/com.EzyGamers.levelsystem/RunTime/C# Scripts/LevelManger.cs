using UnityEngine;
using TMPro;

public class LevelManager : MonoBehaviour
{
    public XpSystem xpSystem; // Reference to the XP system
    public DifficultyAdjuster difficultyAdjuster; // Reference to the DifficultyAdjuster

    [Header("UI Elements")]
    public TextMeshProUGUI levelUpdateText; // UI Text element to display level-up message
    public TextMeshProUGUI currentLevelText; // UI Text element to display the current level

    void Start()
    {
        if (xpSystem != null)
        {
            xpSystem.OnLevelUp += HandleLevelUp; // Subscribe to level-up events
        }

        // Initialize current level display
        UpdateCurrentLevelUI();
    }

    void OnDestroy()
    {
        if (xpSystem != null)
        {
            xpSystem.OnLevelUp -= HandleLevelUp; // Unsubscribe to prevent memory leaks
        }
    }

    private void HandleLevelUp(int newLevel)
    {
        Debug.Log($"Player leveled up! New Level: {newLevel}");

        // Update level-up message
        if (levelUpdateText != null)
        {
            levelUpdateText.text = $"Level Up! You are now Level {newLevel}";
        }

        // Update the current level display
        UpdateCurrentLevelUI();

        // Update difficulty text (optional, if linked to difficulty adjuster)
        if (difficultyAdjuster != null)
        {
            difficultyAdjuster.UpdateDifficulty(); // Force an update on level-up
        }

        StartCoroutine(HideLevelUpdateText());
    }

    private void UpdateCurrentLevelUI()
    {
        if (currentLevelText != null)
        {
            currentLevelText.text = $"Level: {xpSystem.CurrentLevel}";
        }
    }

    private System.Collections.IEnumerator HideLevelUpdateText()
    {
        yield return new WaitForSeconds(2f);
        if (levelUpdateText != null)
        {
            levelUpdateText.text = ""; // Clear the message
        }
    }
}
