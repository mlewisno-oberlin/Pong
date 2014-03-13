using UnityEngine;
using System.Collections;

public class ControlOptionMenuScript : MonoBehaviour
{
	const int buttonWidth = 500;
	const int buttonHeight = 100;
	public Font ourFont;
	public Font header_font;
	public Texture2D white_color;
	public GUISkin my_skin;

	void OnGUI () {
		GUI.skin.font = ourFont;
		GUI.skin = my_skin;
		GUI.backgroundColor = Color.white;
		GUI.contentColor = Color.black;
		GUI.skin.button.hover.background = white_color;
		GUI.skin.button.onHover.background = white_color;
		GUI.skin.button.active.background = white_color;
		GUI.skin.button.normal.background = white_color;
		// Sets up the two highest level areas
		// Area One
		GUILayout.BeginArea( new Rect (Screen.width * 0.1f, Screen.height * 0.001f, Screen.width, 0.9f * Screen.height));
			GUILayout.BeginHorizontal ();
				// Sets up the left section of the menu which handles general settings
				GUILayout.BeginArea( new Rect (0, 0, Screen.width/2 - Screen.width*0.1f, 0.9f * Screen.height));
					GUILayout.BeginVertical();
						GUI.skin.font = header_font;
						GUILayout.Label("General Settings");
						GUI.skin.font = ourFont;
							SettingsVariables.four_players = GUILayout.Toggle (SettingsVariables.four_players, "4 Players");
							SettingsVariables.music = GUILayout.Toggle (SettingsVariables.music, "Music");
							SettingsVariables.sound_effects = GUILayout.Toggle (SettingsVariables.sound_effects, "Sound Effects");
						GUI.skin.font = header_font;
						GUILayout.Label("PowerUps");
						GUI.skin.font = ourFont;
							SettingsVariables.gravity = GUILayout.Toggle (SettingsVariables.gravity, "Gravity");
							SettingsVariables.reverse_gravity = GUILayout.Toggle (SettingsVariables.reverse_gravity, "Reverse Gravity");
							SettingsVariables.bounciness = GUILayout.Toggle (SettingsVariables.bounciness, "Increased Bounciness");
							SettingsVariables.elongation = GUILayout.Toggle (SettingsVariables.elongation, "Paddle Elongation");
							SettingsVariables.no_walls = GUILayout.Toggle (SettingsVariables.no_walls, "Transformation");
							// SettingsVariables.split_time = GUILayout.Toggle (SettingsVariables.split_time, "Split Time");
					GUILayout.EndVertical();
				GUILayout.EndArea();
				
				
				GUILayout.BeginArea( new Rect (Screen.width/2 - Screen.width * 0.1f, 0, Screen.width/2 - Screen.width*0.1f, 0.9f * Screen.height));
					GUILayout.BeginVertical();
						// Label for the section
						GUI.skin.font = header_font;
						GUILayout.Label("Player Settings");
						GUI.skin.font = ourFont;
						// Label and slider for the first ediutable parameter, player sensetivity
						GUILayout.Label ("Team One Player 1 Sensetivity = " + shorten(SettingsVariables.teamOnePlayerOneSpeed));
							SettingsVariables.teamOnePlayerOneSpeed = GUILayout.HorizontalSlider (SettingsVariables.teamOnePlayerOneSpeed, 20.0f, 30.0f);
							GUILayout.Label ("Team One Player 2 Sensetivity = " + shorten(SettingsVariables.teamOnePlayerTwoSpeed));
							SettingsVariables.teamOnePlayerTwoSpeed = GUILayout.HorizontalSlider (SettingsVariables.teamOnePlayerTwoSpeed, 20.0f, 30.0f);
							GUILayout.Label ("Team Two Player 1 Sensetivity = " + shorten(SettingsVariables.teamTwoPlayerOneSpeed));
							SettingsVariables.teamTwoPlayerOneSpeed = GUILayout.HorizontalSlider (SettingsVariables.teamTwoPlayerOneSpeed, 20.0f, 30.0f);
							GUILayout.Label ("Team Two Player 2 Sensetivity = " + shorten(SettingsVariables.teamTwoPlayerTwoSpeed));
							SettingsVariables.teamTwoPlayerTwoSpeed = GUILayout.HorizontalSlider (SettingsVariables.teamTwoPlayerTwoSpeed, 20.0f, 30.0f);
					GUILayout.EndVertical ();
				GUILayout.EndArea();
			GUILayout.EndHorizontal ();
		GUILayout.EndArea();

		// Area Two
		GUILayout.BeginArea (new Rect (0, Screen.height * 0.88f, Screen.width, Screen.height * 0.1f));
			GUILayout.BeginHorizontal ();
				// Draw a button to go back to the main menu
				if (GUILayout.Button("Main Menu"))
				{
					// On Click, close the game.
					Application.LoadLevel ("Menu");
				}
			GUILayout.EndHorizontal ();
		GUILayout.EndArea();
	}

	float shorten(float number){
			number = number * 10;
			int middle = (int) number;
			number = middle/10f;
			return number;
	}
	
}
