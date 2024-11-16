using System;
using UnityEngine;

public class XpSystem : MonoBehaviour
{
    public int CurrentXP { get; private set; }
    public int CurrentLevel { get; private set; }

    public event Action<int> OnLevelUp;

    [SerializeField]
    private XpSettings xpSettings;  // Reference to XPSettings ScriptableObject

    private void Start()
    {
        CurrentLevel = 1;
        CurrentXP = 0;

        AddXP(1000);
        

    }

    public void AddXP(int amount)
    {
        CurrentXP += amount;
        Debug.Log("Added XP: " + amount);
        Debug.Log("Current XP: " + CurrentXP);

        // Check if XP threshold is reached to level up
        if (CurrentXP >= xpSettings.GetXPThreshold(CurrentLevel))
        {
            LevelUp();
        }
    }

    private void LevelUp()
    {
        CurrentLevel++;
        CurrentXP = 0; // Reset XP after level up
        OnLevelUp?.Invoke(CurrentLevel); // Trigger event for other scripts to listen to
        Debug.Log("Leveled Up! New level: " + CurrentLevel);
    }

    public int GetCurrentLevelXPThreshold()
    {
        return xpSettings.GetXPThreshold(CurrentLevel);
    }
}
