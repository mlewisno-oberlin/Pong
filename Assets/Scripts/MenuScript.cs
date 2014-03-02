using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour
{
	void OnGUI()
	{
		const int buttonWidth = 84;
		const int buttonHeight = 40;
		
		GUI.backgroundColor = Color.black;
		//GUI.color = Color.black;
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
		if (
			GUI.Button(
			// Center in X, 2/3 of the height in Y
			new Rect(
			Screen.width / 2 - (buttonWidth / 2),
			(2 * Screen.height / 4) + (buttonHeight * 1.15f) - (buttonHeight / 2),
			buttonWidth,
			buttonHeight
			),
			"Credits"
			)
			)
		{
			// On Click, load the first level.
			// "Stage1" is the name of the first scene we created.
			Application.LoadLevel("Credits");
		}
		if (
			GUI.Button(
			// Center in X, 2/3 of the height in Y
			new Rect(
			Screen.width / 2 - (buttonWidth / 2),
			(2 * Screen.height / 4) + (buttonHeight * 1.15f) + (buttonHeight / 2 + buttonHeight * 0.15f),
			buttonWidth,
			buttonHeight
			),
			"Exit Game"
			)
			)
		{
			// On Click, load the first level.
			// "Stage1" is the name of the first scene we created.
			Application.LoadLevel("Credits");
		}
	}
}
