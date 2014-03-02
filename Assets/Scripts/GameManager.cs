using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	static int Team01Score = 0;
	static int Team02Score = 0;
	public GUISkin scoreDisplay;

	// Variables for the gravity powerup

	// Updates Score
	public static void Score (string WallName) {
		if (WallName.Equals("leftWall")){
		    Team02Score += 1;
		}
		else if (WallName.Equals("rightWall")){
			Team01Score += 1;
		}
	}

	// Displays the score
	void OnGUI () {
		GUI.skin = scoreDisplay;
		GUI.Label (new Rect (Screen.width / 2 - 150, Screen.height - 55, 100, 100), "" + Team01Score);
		GUI.Label (new Rect (Screen.width / 2 + 150, Screen.height - 55, 100, 100), "" + Team02Score);
		// A little code to truncate the time value being stored
		double timer = SwitchPlanes.time_till_switch;
		int intermediate = (int)(timer * 100);
		timer = (double)intermediate / 100.0;
		if (timer <= 3.00) {
			scoreDisplay.label.normal.textColor = Color.red;
				}
		GUI.Label (new Rect (Screen.width / 2 - 35, 25, 100, 100), "" + timer);
		scoreDisplay.label.normal.textColor = Color.white;
	}
	
}
