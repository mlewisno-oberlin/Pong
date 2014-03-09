using UnityEngine;

using System.Collections;



public class PlayerControls : MonoBehaviour {

	public static BoxCollider2D topWall;
	public static BoxCollider2D bottomWall;
	public KeyCode moveUp = KeyCode.W;
	public KeyCode moveDown = KeyCode.S;
	public bool controllable = true;
	public float speed = 20;

	
	void Update () {
		
		if (controllable) {
		
				if (Input.GetKey (moveUp)) {
						rigidbody2D.velocity = new Vector3 (0, speed, 0);
				} else if (Input.GetKey (moveDown)) {
						rigidbody2D.velocity = new Vector3 (0, -1 * speed, 0);
				} else {
						rigidbody2D.velocity = new Vector3 (0, 0, 0);
				}
						rigidbody2D.velocity = new Vector3 (0, rigidbody2D.velocity.y, 0);
				} else {
					rigidbody2D.velocity = new Vector3 (0, 0, 0);
				}
	}

	// These three methods update the players keys and speed
	public void setUp(KeyCode newUp){
		moveUp = newUp;
		}

	public void setDown(KeyCode newDown){
		moveDown = newDown;
	}

	public void setSpeed(float newSpeed){
				speed = newSpeed;
		}

	// Transforms the player to the opposite wall when the wall is a trigger
	void TeleportPlayer(){
		if (this.transform.position.y > 0) {
			this.transform.position = new Vector3(this.transform.position.x, bottomWall.center.y + 2 * 0.7f, this.transform.position.z);
		}
		else{
			this.transform.position = new Vector3(this.transform.position.x, topWall.center.y - 2 * 0.7f, this.transform.position.z);
		}
	}
	
}