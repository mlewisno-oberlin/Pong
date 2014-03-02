using UnityEngine;
using System.Collections;



public class MenuGameSetup : MonoBehaviour {
	
	public Camera mainCamera;
	public BoxCollider2D topWall;
	public BoxCollider2D bottomWall;
	public BoxCollider2D leftWall;
	public BoxCollider2D rightWall;
	
	
	
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
	}
	
	void Update () {
		// Updates the color of the ball according to its	
		
		
	}
	
}