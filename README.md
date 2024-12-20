Overview
	This package provides a flexible, generic level progression and difficulty adjustment system designed for language learning games, though it can be used for any type of game that requires level progression and difficulty 		scaling. The package includes configurable XP thresholds, a progress bar, and a difficulty adjustment system based on player performance, all accessible via ScriptableObjects for easy tuning.

Features
	XP System: Manage XP accumulation and define level thresholds.
	Level Progression: Configurable level progression system.
	Progress Bar: Visual representation of XP progress toward the next level.
	Difficulty Adjustment: Dynamic scaling of game difficulty based on player level.
	ScriptableObjects for Configuration: Store all key values (e.g., XP rewards, difficulty settings) in ScriptableObjects to allow for easy configuration.
Installation
	Clone or Download the Package: Download this repository or clone it to your Unity project folder.
	Add the Package to Unity:
	Open Unity and go to Window > Package Manager.
	Click the "+" button and choose "Add package from disk."
	Navigate to the folder containing the com.ezygamers.levelsystem package, select the package.json file, and click "Open."


Package Contents
	1. Scripts
		XPSystem.cs: Manages XP accumulation, level thresholds, and progress bar updates.
		LevelManager.cs: Handles overall level progression and manages difficulty scaling.
		ProgressBar.cs: Controls the visual representation of XP progress in the UI.
		DifficultyAdjuster.cs: Adjusts difficulty settings based on player level.
	
	2. ScriptableObjects
		XPThresholdSettings.asset: Stores XP thresholds required for each level.
		DifficultySettings.asset: Holds configuration for difficulty parameters, including easy, medium, and hard difficulty modes.
	
	3. UI Elements (Optional)
		Progress Bar: UI slider showing progress toward the next level.
		Difficulty Text: Displays the current difficulty level in the UI.
Getting Started
	Step 1: Configure XP System
		Create XP Threshold Settings:

		In the Project window, right-click and choose Create > Level System > XP Threshold Settings.
		Configure XP thresholds by level, adjusting values to control how much XP is needed to level up.
		Set Up XPSystem Component:

		Add the XpSystem script to a GameObject in the scene.
		Assign the XPThresholdSettings asset to the XPSystem component in the Inspector.
	
	Step 2: Configure Difficulty Adjuster
		Create Difficulty Settings:

		Right-click in the Project window and choose Create > Level System > Difficulty Settings.
		Configure settings like easyEnemySpeed, mediumEnemySpeed, and hardEnemySpeed based on your gameplay.
		Set Up DifficultyAdjuster Component:

		Add the DifficultyAdjuster script to a GameObject in the scene.
		Assign the DifficultySettings asset to the DifficultyAdjuster component in the Inspector.
	
	Step 3: Configure Progress Bar (Optional)
		Create a UI > Slider in your scene to represent the XP progress.
		Attach the ProgressBar script to the Slider object and link it to the XPSystem.
	
	Step 4: Configure Level Manager
		Add the LevelManager script to a GameObject in the scene.
		Link the XPSystem and DifficultyAdjuster components to the LevelManager in the Inspector.
		Usage
	

	Testing XP Gain:

		Call the GainXP(int amount) function in XPSystem to simulate gaining XP. This will progress the level and adjust the difficulty as needed.
		Use Debug Logs or UI elements to monitor XP, level, and difficulty changes.
		Difficulty Scaling:

		The DifficultyAdjuster automatically updates the game’s difficulty based on the player’s level.
		Customize settings in DifficultySettings to control gameplay changes (e.g., enemy speed, spawn rates) based on difficulty.
		Advanced Configuration:

		Use ScriptableObjects (XPThresholdSettings and DifficultySettings) to adjust XP and difficulty without altering the code.
		These assets make it easy for designers to fine-tune values directly from the Unity Inspector.


Troubleshooting
		Slider Not Updating: Ensure the ProgressBar script is correctly linked to the XPSystem.
		Difficulty Not Adjusting: Verify that the DifficultyAdjuster script is correctly linked in LevelManager and that DifficultySettings is properly configured.
		No Level Up: Check XP thresholds in XPThresholdSettings and ensure the player’s XP meets the threshold to level up.
	
