using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour
{

	public Font ourFont;
	
	void OnGUI()
	{
		const int buttonWidth = 300;
		const int buttonHeight = 40;
		
		GUI.backgroundColor = Color.black;
		GUI.skin.font = ourFont;
		
		// Draw a button to start the game
		if (
			GUI.Button(
			// Center in X, 2/3 of the height in Y
			new Rect(
			Screen.width / 2 - (buttonWidth / 2),
			(2 * Screen.height / 4) - (buttonHeight / 2),
			buttonWidth,
			buttonHeight
			),
			"Play Pong!"
			)
			)
		{
			// On Click, load the first level.
			// "Stage1" is the name of the first scene we created.
			Application.LoadLevel("Stage1");
		}
		
		// Draw a button to open the options menu
		if (
			GUI.Button(
			// Center in X, 2/3 of the height in Y
			new Rect(
			Screen.width / 2 - (buttonWidth / 2),
			(2 * Screen.height / 4) + (buttonHeight * 1.15f) - (buttonHeight / 2),
			buttonWidth,
			buttonHeight
			),
			"Options"
			)
			)
		{
			// On Click, roll the credits
			Application.LoadLevel("OptionsMenu");
		}
		
		// Draw a button to play the credits
		if (
			GUI.Button(
			// Center in X, 2/3 of the height in Y
			new Rect(
			Screen.width / 2 - (buttonWidth / 2),
			(2 * Screen.height / 4) + (buttonHeight * 1.15f) + (buttonHeight / 2 + buttonHeight*0.15f),
			buttonWidth,
			buttonHeight
			),
			"Credits"
			)
			)
		{
			// On Click, roll the credits
			Application.LoadLevel("Credits");
		}
		
		// Draw a button to close the game
		if (
			GUI.Button(
			// Center in X, 2/3 of the height in Y
			new Rect(
			Screen.width / 2 - (buttonWidth / 2),
			(2 * Screen.height / 4) + (buttonHeight * 1.15f) + (buttonHeight * 1.65f),
			buttonWidth,
			buttonHeight
			),
			"Exit Game"
			)
			)
		{
			// On Click, close the game.
			Application.Quit ();
		}
	}
	
}
