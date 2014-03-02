using UnityEngine;
using System.Collections;

public class WallTrigger : MonoBehaviour {

	// This fuction handles the collision of this wall with the ball
	void OnTriggerEnter2D (Collider2D hitInfo) {
		if (hitInfo.name.Equals ("Ball")) {
			string wallName = transform.name;
			GameManager.Score (wallName);
			hitInfo.gameObject.SendMessage("ResetBall");
		}
	}

}
