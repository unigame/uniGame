using UnityEngine;
using System.Collections;

public class GuiDrawSlider : MonoBehaviour 
{
	/// <summary>
	/// The vertical/horizontal value.
	/// </summary>
	private int verticalValue = 0;
	private float horizontalValue = 0;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
	
	void OnGUI()
	{
		// get the move speed
		verticalValue = (int)GUI.VerticalSlider(new Rect(25, 25, 30, 100), verticalValue, 100, 0);
		horizontalValue = GUI.HorizontalSlider(new Rect(50, 25, 100, 30), horizontalValue, 100.0f, 0.0f);
		
		GUI.Label(new Rect(10, 150, Screen.width, 30), "Vertical -> " + verticalValue + "%");
		GUI.Label(new Rect(10, 200, Screen.width, 30), "Horizontal -> " + horizontalValue + "%");
	}
}
