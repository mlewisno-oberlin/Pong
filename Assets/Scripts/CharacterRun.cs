﻿using UnityEngine;
using System.Collections;

public class CharacterRun : MonoBehaviour {

	float timer = 10f;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;
		if(timer <= 0){
			Application.LoadLevel("Menu");
		}
	}
}
