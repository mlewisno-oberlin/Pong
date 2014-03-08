using UnityEngine;
using System.Collections;

public class ControlOptionMenuScript : MonoBehaviour
{
	public Font ourFont;
	public GUISkin skin;
	const int buttonWidth = 500;
	const int buttonHeight = 100;

	void OnGUI () {
		SettingsVariables.four_players = GUI.Toggle 
					(new Rect (Screen.width / 2 - (buttonWidth / 2),
        			(2 * Screen.height / 4) - (buttonHeight * 1.15f) - (buttonHeight / 2),
       				buttonWidth,
        			buttonHeight), 
				SettingsVariables.four_players, "Enable 4 Players");

		// Draw a button to go back to the options menu
		if (
			GUI.Button(
			// Center in X, 2/3 of the height in Y
			new Rect(
			Screen.width / 2 - (buttonWidth / 2),
			(2 * Screen.height / 4) - (buttonHeight * 1.15f),
			buttonWidth,
			buttonHeight
			),
			"Back to Options Menu"
			)
			)
		{
			// On Click, close the game.
			Application.LoadLevel ("OptionsMenu");
		}

		// Draw a button to go back to the main menu
		if (
			GUI.Button(
			// Center in X, 2/3 of the height in Y
			new Rect(
			Screen.width / 2 - (buttonWidth / 2),
			(2 * Screen.height / 4) - (buttonHeight * 1.15f) + (buttonHeight * 1.65f),
			buttonWidth,
			buttonHeight
			),
			"Back to Main Menu"
			)
			)
		{
			// On Click, close the game.
			Application.LoadLevel ("Menu");
		}
	}
	
}
