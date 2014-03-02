using UnityEngine;
using System.Collections;

public class PowerUpSpawn : MonoBehaviour {
		
	public static double time_till_switch;
	public Camera mainCamera;
	
	// The powerups
	public Transform gravityPowerUp;
	public Transform reverseGravityPowerUp;
	public Transform ballSplitPowerUp;
	public Transform noWallPowerUp;
	public Transform elongationPowerUp;
	public Transform splitTimePowerUp;
	public Transform bouncePowerUp;
	
	// The 4 walls
	public BoxCollider2D topWall;
	public BoxCollider2D bottomWall;
	public BoxCollider2D leftWall;
	public BoxCollider2D rightWall;

	// Runs on start
	void Start(){
		time_till_switch = 10;
		}

	// Update is called once per frame
	void Update () {
		if (time_till_switch <= 0) {
			pickPowerUp ();
			time_till_switch = Random.Range(2.0f, 12.5f);
				} else {
						time_till_switch -= Time.deltaTime;
				}
	}

	void pickPowerUp(){
		int randomNumber = Random.Range (0, 6);
		// If randomNumber is 1, spawn a BallSplit powerup
		if (randomNumber == 1) {
			spawnReverseBallGravity();
		}
		// If randomNumber is 2, spawn an increase bounciness powerup
		if (randomNumber == 2) {
			spawnBounce();
		}
		// If randomNumber is 3, spawn a wall removal powerup
		if (randomNumber == 3) {
			spawnNoWall();
		}
		// If randomNumber is 4, spawn a player size increase powerup
		if (randomNumber == 4) {
			spawnElongation();
		}
		// If randomNumber is 6, spawn a Gravity powerup
		if (randomNumber == 5) {
			spawnBallGravity();
		}
	}

	// These functions spawn the powerups
	void spawnSplit(){
		var powerUp = Instantiate(splitTimePowerUp) as Transform;
		// Assign position
		float[] coords = getCoords();
		powerUp.position = new Vector2(coords[0], coords[1]);
		}
	void spawnBounce(){
		var powerUp = Instantiate(bouncePowerUp) as Transform;
		// Assign position
		float[] coords = getCoords();
		powerUp.position = new Vector2(coords[0], coords[1]);
		}
	void spawnNoWall(){
		var powerUp = Instantiate(noWallPowerUp) as Transform;
		// Assign position
		float[] coords = getCoords();
		powerUp.position = new Vector2(coords[0], coords[1]);
		}
	void spawnElongation(){
		var powerUp = Instantiate(elongationPowerUp) as Transform;
		// Assign position
		float[] coords = getCoords();
		powerUp.position = new Vector2(coords[0], coords[1]);
		}
	void spawnSplitTime(){
		var powerUp = Instantiate(splitTimePowerUp) as Transform;
		// Assign position
		float[] coords = getCoords();
		powerUp.position = new Vector2(coords[0], coords[1]);
		}
	void spawnBallGravity(){
		var powerUp = Instantiate(gravityPowerUp) as Transform;
		// Assign position
		float[] coords = getCoords();
		powerUp.position = new Vector2(coords[0], coords[1]);
		}
	void spawnReverseBallGravity(){
		var powerUp = Instantiate(reverseGravityPowerUp) as Transform;
		// Assign position
		float[] coords = getCoords();
		powerUp.position = new Vector2(coords[0], coords[1]);
	}

	// Picks random coords in the game space to spawn the power up
	float[] getCoords(){
		float[] coords = new float[2];
		coords[0] = Random.Range (leftWall.center.x + 20.5f, rightWall.center.x - 20.5f);
		coords[1] = Random.Range (bottomWall.center.y + 10, topWall.center.y - 10);
		return coords;
	}
}
