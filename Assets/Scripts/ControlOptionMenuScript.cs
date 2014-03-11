using UnityEngine;
using System.Collections;

public class ControlOptionMenuScript : MonoBehaviour
{
	public Font ourFont;
	public GUISkin skin;
	const int buttonWidth = 500;
	const int buttonHeight = 100;

	// Keeps track of slider position
	private float hSliderValue = 20.0f;

	void OnGUI () {
		// This area handles the general game settings
		GUILayout.BeginArea (new Rect (Screen.width/4, Screen.height/4, 300, 300));
		// This checkbox enables 4 players
		SettingsVariables.four_players = GUILayout.Toggle (SettingsVariables.four_players, "Enable 4 Players");

		GUILayout.EndArea ();

		// This area handles the individual player settings
		GUILayout.BeginArea (new Rect (Screen.width/2, Screen.height/2, 300, 300));

		// This sliding bar changes the player speed 
		GUILayout.Label ("Sensetivity");
		SettingsVariables.teamOnePlayerOneSpeed = GUILayout.HorizontalSlider (SettingsVariables.teamOnePlayerOneSpeed, 20.0f, 30.0f);

		GUILayout.EndArea ();

		// This area holds the menu options to change menus
		GUILayout.BeginArea (new Rect (0, 0, Screen.width, 100));
		GUILayout.BeginHorizontal ();

		// Draw a button to go back to the options menu
		if (GUILayout.Button("Options Menu"))
		{
			// On Click, close the game.
			Application.LoadLevel ("OptionsMenu");
		}

		// Draw a button to go back to the main menu
		if (GUILayout.Button("Main Menu"))
		{
			// On Click, close the game.
			Application.LoadLevel ("Menu");
		}
		GUILayout.EndHorizontal ();
		GUILayout.EndArea ();
	}

	void Update(){
		Debug.Log (hSliderValue);
	}
	
}
