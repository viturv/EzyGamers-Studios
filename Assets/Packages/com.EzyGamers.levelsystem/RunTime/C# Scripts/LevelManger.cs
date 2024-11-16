using UnityEngine;
using UnityEngine.Rendering.VirtualTexturing;

public class LevelManger : MonoBehaviour
{
    public XpSystem xpSystem;               // Reference to XPSystem
    public DifficultyAdjuster difficultyAdjuster;  // Reference to DifficultyAdjuster

    private void Awake()
    {
        xpSystem.OnLevelUp += OnLevelUp;
    }

    private void OnDestroy()
    {
        xpSystem.OnLevelUp -= OnLevelUp;
    }

    private void OnLevelUp(int newLevel)
    {
        // Adjust difficulty when the player levels up
        difficultyAdjuster.AdjustDifficulty();
    }
}
