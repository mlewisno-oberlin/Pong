using UnityEngine;
using System.Collections;

public class BallControl : MonoBehaviour {

	// Variable for the ball velocity
	public Vector3 stored_velocity;

	// The wall variables for the no walls powerup
	public BoxCollider2D topWall;
	public BoxCollider2D bottomWall;
	public Camera mainCamera;

	// Variables for the ball gravity feature
	public float duration = 20;
	float gravity_timer = 0;
	bool gravity_activated = false;
	float reverse_gravity_timer = 0;
	bool reverse_gravity_activated = false;
	
	// Variables for the bounce timer
	bool bounce_activated = false;
	float bounce_timer = 0;
	
	// Variables for the elongation 
	Collision2D last_player;
	bool been_set = false;

	public void pauseBall(){
		stored_velocity = rigidbody2D.velocity;
		rigidbody2D.velocity = new Vector3(0, 0, 0);
	}

	public void unPause(){
		rigidbody2D.velocity = stored_velocity;
	}

	//Use this for initialization
	IEnumerator Start () {
		yield return new WaitForSeconds(2);
		BallStart ();
	}

	// When the object impacts 
	void OnCollisionEnter2D (Collision2D colInfo) {
		// Fricton element, added only sometimes
		 if (colInfo.collider.tag == "Player") {
			last_player = colInfo;
			been_set = true;
			float velY = rigidbody2D.velocity.y;
			rigidbody2D.velocity = rigidbody2D.velocity - new Vector2 (0, velY/2);
			rigidbody2D.velocity = rigidbody2D.velocity + new Vector2 (0, colInfo.collider.rigidbody2D.velocity.y/3);
		}
	}

	// When the ball hits a trigger object, checks for the power up type and calls the appropriate method
	void OnTriggerEnter2D (Collider2D hitInfo) {
		// Check for the ball
		if(hitInfo.name.Contains("PowerUpGravity")){
			gravity_activated = true;
			gravity_timer = 6;
			gravityOn ();
		}
		if(hitInfo.name.Contains("PowerUpReverseGravity")){
			reverse_gravity_activated = true;
			reverse_gravity_timer = 6;
			reverse_gravityOn ();
		}
		if(hitInfo.name.Contains("PowerUpBounce")){
			bounce_activated = true;
			bounce_timer = 6;
			bounceOn ();
		}
		if(hitInfo.name.Contains("PowerUpElongation")){
			if(been_set){
				PlayerLength.elongationOn(last_player);
			}
		}
		if(hitInfo.name.Contains("PowerUpNoWalls")){
			wallTransform.topWall = this.topWall;
			wallTransform.bottomWall = this.bottomWall;
			PlayerControls.topWall = this.topWall;
			PlayerControls.bottomWall = this.bottomWall;
			wallTransform.transformOn();
		}
	}

	// Update checks timers for the ball effects
	void Update () {
		// Updates the timer for the gravity powerup
		if (gravity_timer >= 0 && gravity_activated) {
			gravity_timer -= Time.deltaTime;
		}
		// If its less than or equal to 0, turn gravity back off
		if (gravity_timer < 0 && gravity_activated) {
			gravityOff();
		}

		// Updates the timer for the gravity powerup
		if (reverse_gravity_timer >= 0 && reverse_gravity_activated) {
			reverse_gravity_timer -= Time.deltaTime;
		}
		// If its less than or equal to 0, turn gravity back off
		if (reverse_gravity_timer < 0 && reverse_gravity_activated) {
			reverse_gravityOff();
		}

		// Updates the timer for the bounce powerup
		if (bounce_timer >= 0 && bounce_activated) {
			bounce_timer -= Time.deltaTime;
		}
		// If its less than or equal to 0, turn bounce back off
		if (bounce_timer < 0 && bounce_activated) {
			bounceOff();
		}

	}
	
	void gravityOn(){
		this.rigidbody2D.gravityScale = 0.6f;
	}

	void gravityOff(){
		this.rigidbody2D.gravityScale = 0;
	}

	void reverse_gravityOn(){
		this.rigidbody2D.gravityScale = -0.6f;
	}
	
	void reverse_gravityOff(){
		this.rigidbody2D.gravityScale = 0;
	}
	
	void bounceOn(){
		this.collider2D.sharedMaterial.bounciness = 2.5f;
	}
	
	void bounceOff(){
		this.collider2D.sharedMaterial.bounciness = 1.3f;
	}

	// Places the ball in the center, waits half a second, and then calls BallStart
	IEnumerator ResetBall(){
		rigidbody2D.velocity = new Vector2 (0, 0);
		float zpos = transform.position.z;
		transform.position = new Vector3 (0, 0, zpos);
		yield return new WaitForSeconds(0.5f);
		been_set = false;
		if(!SettingsVariables.menu_active){
			BallStart ();
		}

	}

	// Picks a direction for the ball and sets if off in that direction
	void BallStart (){
		int randomNumber = Random.Range (0, 2);
		int upOrDown = Random.Range (0, 2);
		
		if (randomNumber == 0) {
			if(upOrDown == 0){
				rigidbody2D.AddForce (new Vector2 (-80, -10));
			}
			else {
				rigidbody2D.AddForce (new Vector2 (-80, 10));
			}
		} else {
			if(upOrDown == 0){
				rigidbody2D.AddForce (new Vector2 (80, 10));
			}
			else {
				rigidbody2D.AddForce (new Vector2 (80, -10));
			}
		}
	}

	// Transforms the ball to the opposite wall 
	void TeleportBall(){
		if (this.transform.position.y > 0) {

			this.transform.position = new Vector3(this.transform.position.x, bottomWall.center.y + 2 * .5f, this.transform.position.z);
				}
		else{
			this.transform.position = new Vector3(this.transform.position.x, topWall.center.y - 2 * .5f, this.transform.position.z);
		}
	}
}
