using UnityEngine;
using System.Collections;

public class ControlOptionMenuScript : MonoBehaviour
{
	public Font ourFont;
	public GUISkin skin;
	const int buttonWidth = 500;
	const int buttonHeight = 100;
	private int toolbarInt = 0;
	private string[] toolbarStrings = {"P1", "P2", "P3", "P4"};

	// Keeps track of slider position
	private float hSliderValue = 20.0f;

	void OnGUI () {
		// Sets up the two highest level areas
		// Area One
		GUILayout.BeginArea( new Rect (Screen.width * 0.1f, Screen.height * 0.1f, Screen.width, 0.9f * Screen.height));
			GUILayout.BeginHorizontal ();
				// Sets up the left section of the menu which handles general settings
		GUILayout.BeginArea( new Rect (0, 0, Screen.width/2 - Screen.width*0.1f, 0.9f * Screen.height));
					SettingsVariables.four_players = GUILayout.Toggle (SettingsVariables.four_players, "Enable 4 Players");
				GUILayout.EndArea();
				
				
				GUILayout.BeginArea( new Rect (Screen.width/2 - Screen.width*0.1f, 0, Screen.width/2 - Screen.width*0.1f, 0.9f * Screen.height));
					GUILayout.BeginVertical ();
						// Label for the section
						GUILayout.Label("Player Settings");
						// Toolbar for selecting which player's settings to change
						toolbarInt = GUILayout.Toolbar (toolbarInt, toolbarStrings);
						// Label and slider for the first ediutable parameter, player sensetivity
						GUILayout.Label ("Sensetivity");
						SettingsVariables.teamOnePlayerOneSpeed = GUILayout.HorizontalSlider (SettingsVariables.teamOnePlayerOneSpeed, 20.0f, 30.0f);
						// Label and entry box for the Up Key
						GUILayout.Label ("Up Key");
						
						// Label and entry box for the Down Key
						GUILayout.Label ("Down Key");
					GUILayout.EndVertical ();
				GUILayout.EndArea();


			GUILayout.EndHorizontal ();
		GUILayout.EndArea();

		// Area Two
		GUILayout.BeginArea (new Rect (0, Screen.height * 0.9f, Screen.width, Screen.height * 0.1f));
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
		GUILayout.EndArea();

		GUILayout.BeginArea (new Rect (Screen.width/2, Screen.height/4, 300, 300));

		// This sliding bar changes the player speed 


		GUILayout.EndArea ();
	}

	void Update(){

	}
	
}
