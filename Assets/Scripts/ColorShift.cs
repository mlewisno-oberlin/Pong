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
	Color current_color;
	string current_color_name;

	// Use this for initialization
	void Start () {
		current_color = color1;
		current_color_name = "Color 1";
	}
	
	// Update is called once per frame
	void Update () {
		// Fades color 1 towards color 2
		if(current_color_name.Equals("Color 1")){
			//updateColor(color2, "Color 2");
			logo.renderer.material.color = current_color;
		}
	}
	
	void updateColor(Color next_color, string next_state){
		// Fades color 1 towards color 2
			if(current_color.Equals(next_color)){
				current_color_name = next_state;
			}
			else{
				if(current_color.r > next_color.r){
					current_color.r -= 1;
				}
			if(current_color.r < next_color.r){
					current_color.r += 1;
				}
			if(current_color.g > next_color.g){
					current_color.g -= 1;
				}
			if(current_color.g < next_color.g){
					current_color.g += 1;
				}
			if(current_color.b > next_color.b){
					current_color.b -= 1;
				}
			if(current_color.b < next_color.b){
					current_color.r += 1;
			}
		}
	}
}
