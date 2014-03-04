using UnityEngine;
using System.Collections;

public class Credits : MonoBehaviour {


	public Camera mainCamera;
	Vector2 screen_top;
	
	// Use this for initialization
	void Start () {
		screen_top = new Vector2 (0f, mainCamera.ScreenToWorldPoint (new Vector3 (0, Screen.height, 0)).y + 0.5f);
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position.y - transform.localScale.y > screen_top.y){
			Application.LoadLevel("Menu");
		}
		transform.rigidbody2D.velocity = new Vector3(0, 1.5f, 0);
	}
}
