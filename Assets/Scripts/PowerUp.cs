using UnityEngine;
using System.Collections;

public class PowerUp : MonoBehaviour {

	void Start()
	{
		// 2 - Limited time to live to avoid any leak
		Destroy(gameObject, 20); // 20sec
	}

	// If a ball hits this, its gravity power up code will run, this object oly needs to self destruct
	void OnTriggerEnter2D (Collider2D hitInfo) {
		if (hitInfo.name.Equals ("Ball")) {
			Destroy (gameObject);
		}
	}

}
