using UnityEngine;
using System.Collections;

public class GuiDrawGuiSkin : MonoBehaviour 
{
	// custom skin
	public GUISkin gSkin;
	
	private bool bSelected = false;
	
	private Rect wndRect = new Rect(320, 320, 320, 160);
	
	private string iMsg = string.Empty;
	
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
		// set custom skin to GUI.Skin
		GUI.skin = gSkin;
		
		// draw custom  button
		GUI.Button(new Rect(100, 100, 100, 60), "Custom Button");
		
		// draw custom Toggle
		bSelected = GUI.Toggle(new Rect(20, 50, 100, 40), bSelected, "Custom Toggle");
		
		// draw custom TextField
		iMsg = GUI.TextField(new Rect(240, 40, 200, 40), iMsg, 25);
		
		// register a window
		wndRect = GUI.Window(0, wndRect, FirstWindowFunc, "First Window");
	}
	
	private void FirstWindowFunc(int wndID)
	{
		// create a drag window by free
		GUI.DragWindow();
		
		// draw a button
		GUI.Button(new Rect(20, 20, 100, 60), "Button In Window");
	}
}
