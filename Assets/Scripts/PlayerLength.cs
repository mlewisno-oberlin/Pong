using UnityEngine;
using System.Collections;

public class PlayerLength : MonoBehaviour {

	// Variables for the elongation 
	public static bool elongation_activated_1 = false;
	public static bool elongation_activated_2 = false;
	public static bool elongation_activated_3 = false;
	public static bool elongation_activated_4 = false;

	// Players
	public Transform TeamOnePlayerOne;
	public Transform TeamOnePlayerTwo;
	public Transform TeamTwoPlayerOne;
	public Transform TeamTwoPlayerTwo;

	// Timers for each player
	public static double elongation_timer_1 = 0;
	public static double elongation_timer_2 = 0;
	public static double elongation_timer_3 = 0;
	public static double elongation_timer_4 = 0;
	
	// Update is called once per frame
	void Update () {
		// Updates the timer for the bounce powerup for player 1
		if (elongation_timer_1 >= 0 && elongation_activated_1) {
			elongation_timer_1 -= Time.deltaTime;
		}
		// If its less than or equal to 0, turn bounce back off for player 1
		if (elongation_timer_1 < 0 && elongation_activated_1) {
			elongationOff(TeamOnePlayerOne);
			elongation_activated_1 = false;
		}
		// Updates the timer for the bounce powerup for player 1
		if (elongation_timer_2 >= 0 && elongation_activated_2) {
			elongation_timer_2 -= Time.deltaTime;
		}
		// If its less than or equal to 0, turn bounce back off for player 1
		if (elongation_timer_2 < 0 && elongation_activated_2) {
			elongationOff(TeamOnePlayerTwo);
			elongation_activated_2 = false;
		}
		// Updates the timer for the bounce powerup for player 1
		if (elongation_timer_3 >= 0 && elongation_activated_3) {
			elongation_timer_3 -= Time.deltaTime;;
		}
		// If its less than or equal to 0, turn bounce back off for player 1
		if (elongation_timer_3 < 0 && elongation_activated_3) {
			elongationOff(TeamTwoPlayerOne);
			elongation_activated_3 = false;
		}
		// Updates the timer for the bounce powerup for player 1
		if (elongation_timer_4 >= 0 && elongation_activated_4) {
			elongation_timer_4 -= Time.deltaTime;
		}
		// If its less than or equal to 0, turn bounce back off for player 1
		if (elongation_timer_4 < 0 && elongation_activated_4) {
			elongationOff(TeamTwoPlayerTwo);
			elongation_activated_4 = false;
		}
	}

	public static void elongationOn(Collision2D colInfo){
		if(colInfo.transform.name.Contains("Team 1 - Player1")){
			elongation_timer_1 = 20;
			elongation_activated_1 = true;
			colInfo.transform.localScale = new Vector3(colInfo.transform.localScale.x, (2 * colInfo.transform.localScale.y), colInfo.transform.localScale.z);
		}
		if(colInfo.transform.name.Contains("Team 1 - Player2")){
			elongation_timer_2 = 20;
			elongation_activated_2 = true;
			colInfo.transform.localScale = new Vector3(colInfo.transform.localScale.x, (2 * colInfo.transform.localScale.y), colInfo.transform.localScale.z);
		}
		if(colInfo.transform.name.Contains("Team 2 - Player1")){
			elongation_timer_3 = 20;
			elongation_activated_3 = true;
			colInfo.transform.localScale = new Vector3(colInfo.transform.localScale.x, (2 * colInfo.transform.localScale.y), colInfo.transform.localScale.z);
		}
		if(colInfo.transform.name.Contains("Team 2 - Player2")){
			elongation_timer_4 = 20;
			elongation_activated_4 = true;
			colInfo.transform.localScale = new Vector3(colInfo.transform.localScale.x, (2 * colInfo.transform.localScale.y), colInfo.transform.localScale.z);
		}
	}
	
	public void elongationOff(Transform colInfo){
		colInfo.localScale = new Vector3(colInfo.localScale.x, 1.2f, colInfo.localScale.z);
		Debug.Log ("Shortening!");
	}


}
