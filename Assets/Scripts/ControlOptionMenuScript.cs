using UnityEngine;
using System.Collections;

public class ControlOptionMenuScript : MonoBehaviour
{
	public Font ourFont;	
	private int hSliderValue = 4;
	
	void OnGUI () {
		hSliderValue = GUI.HorizontalSlider (new Rect (25, 25, 100, 30), hSliderValue, 2, 4);
	}
	
}
