﻿using UnityEngine;
using System.Collections;

public class OptionMenuScript : MonoBehaviour
{

	public Font ourFont;
	
	void OnGUI()
	{
		const int buttonWidth = 500;
		const int buttonHeight = 100;
		
		GUI.backgroundColor = Color.black;
		GUI.skin.font = ourFont;
		
		// Draw a button to open the options menu
		if (
			GUI.Button(
			// Center in X, 2/3 of the height in Y
			new Rect(
			Screen.width / 2 - (buttonWidth / 2),
			(2 * Screen.height / 4) - (buttonHeight * 1.15f) - (buttonHeight / 2),
			buttonWidth,
			buttonHeight
			),
			"Player Controls"
			)
			)
		{
			// On Click, roll the credits
			Application.LoadLevel("ControlsMenu");
		}
		
		// Draw a button to play the credits
		if (
			GUI.Button(
			// Center in X, 2/3 of the height in Y
			new Rect(
			Screen.width / 2 - (buttonWidth / 2),
			(2 * Screen.height / 4) - (buttonHeight * 1.15f) + (buttonHeight / 2 + buttonHeight*0.15f),
			buttonWidth,
			buttonHeight
			),
			"Audio"
			)
			)
		{
			// On Click, roll the credits
			Application.LoadLevel("SoundMenu");
		}
		
		// Draw a button to close the game
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
