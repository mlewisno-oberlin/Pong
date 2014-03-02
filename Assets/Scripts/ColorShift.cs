using UnityEngine;
using System.Collections;

public class ColorShift : MonoBehaviour {

	public Transform logo;
	public Color color1;
	public Color color2;
	public Color color3;
	public Color color4;
	public Color color5;
	public Color color6;
	public float duration = 10.0F;
	bool whiteToc1 = true;
	bool c1Toc2 = false;
	bool c2Toc3 = false;
	bool c3Toc4 = false;
	bool c4Toc5 = false;
	bool c5Toc1 = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	
	void Update() {
		float lerp = Mathf.PingPong(Time.time, duration) / duration;

		// Checks to see which stage we're in
		if(closeEnough(renderer.material.color,Color.white)){

			whiteToc1 = change();
		}
		if(closeEnough(renderer.material.color,color1)){

			c1Toc2 = change();
		}
		if(closeEnough(renderer.material.color,color2)){

			c2Toc3 = change();
		}
		if(closeEnough(renderer.material.color,color3)){

			c3Toc4 = change();
		}
		if(closeEnough(renderer.material.color,color4)){

			c4Toc5 = change();
		}
		if(closeEnough(renderer.material.color,color5)){

			c5Toc1 = change();
		}
		
		// Updates the olor depending on which stage we're in
		if(c1Toc2){
			renderer.material.color = Color.Lerp(color1, color2, lerp);
		}else if(c2Toc3){
			renderer.material.color = Color.Lerp(color2, color3, lerp);
		}else if(c3Toc4){
			renderer.material.color = Color.Lerp(color3, color4, lerp);
		}else if(c4Toc5){
			renderer.material.color = Color.Lerp(color4, color5, lerp);
		}else if(c5Toc1){
			renderer.material.color = Color.Lerp(color5, color1, lerp);
		}else if(whiteToc1){
			renderer.material.color = Color.Lerp(renderer.material.color, color1, lerp);
		}
		
	}
	
	bool change(){
		whiteToc1 = false;
		c1Toc2 = false;
		c2Toc3 = false;
		c3Toc4 = false;
		c4Toc5 = false;
		c5Toc1 = false;
		return true;
	}
	
	bool closeEnough(Color color1, Color color2){
		return(((color1.r - color2.r)*(color1.r - color2.r)) < 0.00005 && ((color1.b - color2.b)*(color1.b - color2.b)) < 0.00005 && ((color1.g - color2.g)*(color1.g - color2.g)) < 0.00005);
	}
	
}
