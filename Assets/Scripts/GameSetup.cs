using UnityEngine;
using System.Collections;



public class GameSetup : MonoBehaviour {
	
	public Camera mainCamera;
	public BoxCollider2D topWall;
	public BoxCollider2D bottomWall;
	public BoxCollider2D leftWall;
	public BoxCollider2D rightWall;

	public Color tier1Color = new Color(1, 1, 1);
	public Color tier2Color = new Color(0.5f, 0.5f, 0.5f);

	public float edgeDistancePlayer = 70f;  //75 Pixels

	public Transform TeamOnePlayerOne;
	public Transform TeamOnePlayerTwo;
	public Transform TeamTwoPlayerOne;
	public Transform TeamTwoPlayerTwo;
	
	
	
	void Start () {
		// Set up the boundary walls
		topWall.size = new Vector2 (mainCamera.ScreenToWorldPoint (new Vector3 (Screen.width * 2f, 0, 0)).x ,1f);
		topWall.center = new Vector2 (0f, mainCamera.ScreenToWorldPoint (new Vector3 (0, Screen.height, 0)).y + 0.5f);
		bottomWall.size = new Vector2 (mainCamera.ScreenToWorldPoint (new Vector3 (Screen.width * 2, 0f, 0f)).x, 1f);
		bottomWall.center = new Vector2 (0f, mainCamera.ScreenToWorldPoint (new Vector3( 0f, 0f, 0f)).y - 0.5f);
		leftWall.size = new Vector2(1f, mainCamera.ScreenToWorldPoint(new Vector3(0f, Screen.height*2f, 0f)).y);;
		leftWall.center = new Vector2(mainCamera.ScreenToWorldPoint(new Vector3(0f, 0f, 0f)).x - 0.5f, 0f);
		rightWall.size = new Vector2(1f, mainCamera.ScreenToWorldPoint(new Vector3(0f, Screen.height*2f, 0f)).y);
		rightWall.center = new Vector2(mainCamera.ScreenToWorldPoint(new Vector3(Screen.width, 0f, 0f)).x + 0.5f, 0f);

		// Setup players
		TeamOnePlayerOne.position = new Vector3(mainCamera.ScreenToWorldPoint (new Vector3 (edgeDistancePlayer, 0f, 0f)).x, 0f, 0f);
		TeamOnePlayerTwo.position = new Vector3(mainCamera.ScreenToWorldPoint (new Vector3 (edgeDistancePlayer, 0f, 0f)).x, 0f, 0f);
		TeamTwoPlayerOne.position = new Vector3(mainCamera.ScreenToWorldPoint (new Vector3 (Screen.width - edgeDistancePlayer, 0f, 0f)).x, 0f, 0f);
		TeamTwoPlayerTwo.position = new Vector3(mainCamera.ScreenToWorldPoint (new Vector3 (Screen.width - edgeDistancePlayer, 0f, 0f)).x, 0f, 0f);

		// Disable the colliders for the second players
		TeamOnePlayerTwo.collider2D.enabled = false;
		TeamTwoPlayerTwo.collider2D.enabled = false;
		SwitchPlanes.unlockPlayer(TeamOnePlayerOne);
		SwitchPlanes.unlockPlayer(TeamTwoPlayerOne);
		SwitchPlanes.lockPlayer(TeamOnePlayerTwo);
		SwitchPlanes.lockPlayer(TeamTwoPlayerTwo);
		TeamOnePlayerTwo.renderer.material.color = tier2Color;
		TeamTwoPlayerTwo.renderer.material.color = tier2Color;
		if (!SettingsVariables.four_players) {
			Destroy(TeamOnePlayerTwo.gameObject);
			Destroy(TeamTwoPlayerTwo.gameObject);
				}

		
		
		
	}

	void Update () {
		// Updates the color of the ball according to its	


	}
		
}