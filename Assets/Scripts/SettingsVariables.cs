using UnityEngine;
using System.Collections;

public class SettingsVariables : MonoBehaviour {

	// Global Static Variables for Holding Player Options

	// Keeps track of the number of players the player(s) have asked for
	public static bool four_players = false;

	// Keeps track of which powerups are allowed
	public static bool gravity = true;
	public static bool reverse_gravity = true;
	public static bool no_walls = true;
	public static bool elongation = true;
	public static bool bounciness = true;
	public static bool split_time = false;
	public static bool ball_split = false;

}
