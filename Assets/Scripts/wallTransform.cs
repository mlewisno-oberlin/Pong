using UnityEngine;
using System.Collections;

public class wallTransform : MonoBehaviour {

	public static BoxCollider2D topWall;
	public static BoxCollider2D bottomWall;
	public static double timer_1 = 0;
	public static bool activated_1 = false;

	// Update is called once per frame
	void Update () {
		// Updates the timer for the bounce powerup for player 1
		if (timer_1 >= 0 && activated_1) {
			timer_1 -= Time.deltaTime;
		}
		// If its less than or equal to 0, turn bounce back off for player 1
		if (timer_1 < 0 && activated_1) {
			transformOff();
			activated_1 = false;
		}
	}

	public static void transformOn(){
		// Debug.Log ("Wall Trigger Activated!");
		topWall.isTrigger = true;
		bottomWall.isTrigger = true;
		activated_1 = true;
		timer_1 = 9;
	}

	void transformOff(){
		// Debug.Log ("Deactivated!");
		topWall.isTrigger = false;
		bottomWall.isTrigger = false;
	}

	// When the ball enters the wall area, it sends a teleportation message to the ball 
	void OnTriggerEnter2D (Collider2D hitInfo) {
		if (hitInfo.name.Equals ("Ball")) {
			hitInfo.gameObject.SendMessage("TeleportBall");
		}
		if (hitInfo.name.Contains ("Player")) {
			hitInfo.gameObject.SendMessage("TeleportPlayer");
		}
	}

}
