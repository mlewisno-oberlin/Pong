using UnityEngine;
using System.Collections;

public class PowerUpSpawn : MonoBehaviour
{
		
		public static double time_till_spawn;
		public Camera mainCamera;

		// The array of powerups
		Transform[] powerups;

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
		void Start ()
		{
				int size = 0;
				time_till_spawn = 5;

				// Figure out how big an array to make
				if (SettingsVariables.gravity) {
						size ++;
				}
				if (SettingsVariables.reverse_gravity) {
						size ++;
				}
				if (SettingsVariables.no_walls) {
						size ++;
				}
				if (SettingsVariables.elongation) {
						size ++;
				}
				if (SettingsVariables.bounciness) {
						size ++;
				}
				if (SettingsVariables.split_time) {
						size ++;
				}
				if (SettingsVariables.ball_split) {
						size ++;
				}

				powerups = new Transform[size];

				// Now add the elements to the array
				if (SettingsVariables.gravity) {
						addToArray (gravityPowerUp);
				}
				if (SettingsVariables.reverse_gravity) {
						addToArray (reverseGravityPowerUp);
				}
				if (SettingsVariables.no_walls) {
						addToArray (ballSplitPowerUp);
				}
				if (SettingsVariables.elongation) {
						addToArray (noWallPowerUp);
				}
				if (SettingsVariables.bounciness) {
						addToArray (elongationPowerUp);
				}
				if (SettingsVariables.bounciness) {
						addToArray (splitTimePowerUp);
				}
				if (SettingsVariables.bounciness) {
						addToArray (bouncePowerUp);
				}

		Debug.Log (powerups.Length);
		}

		void addToArray (Transform thingy)
		{
				for (int i = 0; i < powerups.Length; i++) {
						if (powerups [i] == null) {
								powerups [i] = thingy;
								break;
						}
				}
		}

		// Update is called once per frame
		void Update ()
		{
				if (time_till_spawn <= 0) {
						pickPowerUp ();
						time_till_spawn = Random.Range (2.0f, 12.5f);
				} else {
						time_till_spawn -= Time.deltaTime;
				}
		}

		void pickPowerUp ()
		{
				int randomNumber = Random.Range (0, powerups.Length);
				// Call the spawn function using the object from the array
				spawn (powerups [randomNumber]);
		}

		// This function spawns the powerups
		void spawn (Transform thingy)
		{
				var powerUp = Instantiate (thingy) as Transform;
				// Assign position
				float[] coords = getCoords ();
				powerUp.position = new Vector2 (coords [0], coords [1]);
		}

		// Picks random coords in the game space to spawn the power up
		float[] getCoords ()
		{
				float[] coords = new float[2];
				coords [0] = Random.Range (leftWall.center.x + 15.5f, rightWall.center.x - 15.5f);
				coords [1] = Random.Range (bottomWall.center.y + 10, topWall.center.y - 10);
				return coords;
		}
}
