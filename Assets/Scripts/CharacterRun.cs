using UnityEngine;
using System.Collections;

public class CharacterRun : MonoBehaviour {

	// Use this for initialization
	void Start () {
		rigidbody2D.velocity = new Vector3(-10, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position.x < 0){
			rigidbody2D.velocity = new Vector2(0, 0);
		}
	}
}
