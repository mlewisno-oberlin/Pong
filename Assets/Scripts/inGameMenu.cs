using UnityEngine;
using System.Collections;

public class inGameMenu : MonoBehaviour {

	const int buttonWidth = 500;
	const int buttonHeight = 100;
	public Font ourFont;
	public Font header_font;
	public Texture2D white_color;
	public GUISkin my_skin;

	// For pausing the ball
	public Transform the_ball;
	public Vector3 stored_velocity;

	public void pauseGame(){
		stored_velocity = the_ball.rigidbody2D.velocity;
		if(stored_velocity.Equals(new Vector3(0, 0, 0))){
			int randomNumber = Random.Range (0, 2);
			int upOrDown = Random.Range (0, 2);
			
			if (randomNumber == 0) {
				if(upOrDown == 0){
					stored_velocity = new Vector3(-80, -10, 0);
				}
				else {
					stored_velocity = new Vector3(-80, 10, 0);
				}
			} else {
				if(upOrDown == 0){
					stored_velocity = new Vector3(80, 10, 0);
				}
				else {
					stored_velocity = new Vector3(80, -10, 0);
				}
			}
		}
		the_ball.rigidbody2D.velocity = new Vector3(0, 0, 0);
	}
	
	public void unPauseGame(){
		the_ball.rigidbody2D.velocity = stored_velocity;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape) && SettingsVariables.menu_active){
			SettingsVariables.menu_active = false;
			unPauseGame();
		}
		else if(Input.GetKeyDown(KeyCode.Escape) && !SettingsVariables.menu_active){
			SettingsVariables.menu_active = true;
			pauseGame();
		}
	}

	void OnGUI()
	{
		if(SettingsVariables.menu_active){
			const int buttonWidth = 300;
			const int buttonHeight = 40;
			
			GUI.backgroundColor = Color.black;
			GUI.skin.font = ourFont;
			
			// Draw a button to go back to the main menu
			if (
				GUI.Button(
				// Center in X, 2/3 of the height in Y
				new Rect(
				Screen.width / 2 - (buttonWidth / 2),
				(2 * Screen.height / 4) - (buttonHeight * 0.65f),
				buttonWidth,
				buttonHeight
				),
				"Main Menu"
				)
				)
			{
				// On Click, close the game.
				Application.LoadLevel ("Menu");
			}
		}
	}
}
