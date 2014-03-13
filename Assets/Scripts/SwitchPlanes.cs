using UnityEngine;
using System.Collections;

public class SwitchPlanes : MonoBehaviour {

	public double default_time = 10.00;
	public static double time_till_switch;
	public string state = "one";

	public Transform TeamOnePlayerOne;
	public Transform TeamOnePlayerTwo;
	public Transform TeamTwoPlayerOne;
	public Transform TeamTwoPlayerTwo;

	public Color tier1Color = new Color(1, 1, 1);
	public Color tier2Color = new Color(0.5f, 0.5f, 0.5f);

	void Start(){
		time_till_switch = default_time;
		}

	// Update is called once per frame
	void Update () {
		if (SettingsVariables.four_players && !SettingsVariables.menu_active) {
						if (time_till_switch <= 0) {
								Switch (state);
								time_till_switch = default_time;
						} else {

								time_till_switch -= Time.deltaTime;
						}
				}
	}

	void Switch(string state_in) {
		// If the state is one, switch to two and switch the appropriate objects
				if (state_in.Equals ("one")) {
						state = "two";
						// Switch which objects have enabled colliders
						TeamOnePlayerOne.collider2D.enabled = false;
						TeamTwoPlayerOne.collider2D.enabled = false;
						TeamOnePlayerTwo.collider2D.enabled = true;
						TeamTwoPlayerTwo.collider2D.enabled = true;
						unlockPlayer(TeamOnePlayerTwo);
						unlockPlayer(TeamTwoPlayerTwo);
						lockPlayer(TeamOnePlayerOne);
						lockPlayer(TeamTwoPlayerOne);

						// Switch colors to highlight the now activated objects
						TeamOnePlayerOne.renderer.material.color = tier2Color;
						TeamTwoPlayerOne.renderer.material.color = tier2Color;
						TeamOnePlayerTwo.renderer.material.color = tier1Color;
						TeamTwoPlayerTwo.renderer.material.color = tier1Color;

						
				} else if (state_in.Equals ("two")) {
						state = "one";
						// Switch which objects have enabled colliders
						TeamOnePlayerOne.collider2D.enabled = true;
						TeamTwoPlayerOne.collider2D.enabled = true;
						TeamOnePlayerTwo.collider2D.enabled = false;
						TeamTwoPlayerTwo.collider2D.enabled = false;
						unlockPlayer(TeamOnePlayerOne);
						unlockPlayer(TeamTwoPlayerOne);
						lockPlayer(TeamOnePlayerTwo);
						lockPlayer(TeamTwoPlayerTwo);
			
						// Switch colors to highlight the now activated objects
						TeamOnePlayerOne.renderer.material.color = tier1Color;
						TeamTwoPlayerOne.renderer.material.color = tier1Color;
						TeamOnePlayerTwo.renderer.material.color = tier2Color;
						TeamTwoPlayerTwo.renderer.material.color = tier2Color;
				} else {
						state = "one";
						// Switch which objects have enabled colliders
						TeamOnePlayerOne.collider2D.enabled = true;
						TeamTwoPlayerOne.collider2D.enabled = true;
						TeamOnePlayerTwo.collider2D.enabled = false;
						TeamTwoPlayerTwo.collider2D.enabled = false;
						unlockPlayer(TeamOnePlayerOne);
						unlockPlayer(TeamTwoPlayerOne);
						lockPlayer(TeamOnePlayerTwo);
						lockPlayer(TeamTwoPlayerTwo);
			
						// Switch colors to highlight the now activated objects
						TeamOnePlayerOne.renderer.material.color = tier1Color;
						TeamTwoPlayerOne.renderer.material.color = tier1Color;
						TeamOnePlayerTwo.renderer.material.color = tier2Color;
						TeamTwoPlayerTwo.renderer.material.color = tier2Color;
				}
		}

	public static void lockPlayer (Transform player){
		player.GetComponent<PlayerControls>().rigidbody2D.velocity = new Vector3 (0, 0, 0);
		player.GetComponent<PlayerControls>().enabled = false;
	}
	
	public static void unlockPlayer (Transform player){
		player.GetComponent<PlayerControls>().enabled = true;
	}

}
