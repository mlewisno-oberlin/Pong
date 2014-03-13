using UnityEngine;
using System.Collections;

public class SettingsVariables : MonoBehaviour {

	// Global Static Variables for Holding Player Options

	// Keeps track of the number of players the player(s) have asked for
	public static bool four_players = false;

	// Keeps track of various glocal settings
	public static bool music = true;
	public static bool sound_effects = true;

	// Keeps track of which powerups are allowed
	public static bool gravity = true;
	public static bool reverse_gravity = true;
	public static bool no_walls = true;
	public static bool elongation = true;
	public static bool bounciness = true;
	public static bool split_time = false;
	public static bool ball_split = false;

	// Keeps track of whether or not the game is active
	public static bool menu_active = false;

	// Keeps track of each player's control scheme and set sensetivity
	// Team One Player One
	public static float teamOnePlayerOneSpeed = 20;
	public static KeyCode teamOnePlayerOneUp = KeyCode.W;
	public static KeyCode teamOnePlayerOneDown = KeyCode.S;

	// Team One Player Two
	public static float teamOnePlayerTwoSpeed = 20;
	public static KeyCode teamOnePlayerTwoUp = KeyCode.W;
	public static KeyCode teamOnePlayerTwoDown = KeyCode.S;

	// Team Two Player One
	public static float teamTwoPlayerOneSpeed = 20;
	public static KeyCode teamTwoPlayerOneUp = KeyCode.W;
	public static KeyCode teamTwoPlayerOneDown = KeyCode.S;

	// Team Two Player Two
	public static float teamTwoPlayerTwoSpeed = 20;
	public static KeyCode teamTwoPlayerTwoUp = KeyCode.W;
	public static KeyCode teamTwoPlayerTwoDown = KeyCode.S;

}
