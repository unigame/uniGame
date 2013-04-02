using UnityEngine;
using System.Collections;

public class GuiDrawWindow : MonoBehaviour 
{
	private Rect firstWndRect = new Rect(20, 20, 200, 200);
	private Rect secondWndRect = new Rect(250, 20, 200, 200);

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
		// register the two windows
		GUI.Window(0, firstWndRect, FirstWindowFunc, "First Window");
		GUI.Window(1, secondWndRect, SecondWindowFunc, "Second Window");
	}
	
	private void FirstWindowFunc(int wndID)
	{
		GUI.Box(new Rect(10, 50, 150, 50), "Window ID : " + wndID);
		
		if(GUI.Button(new Rect(10, 120, 150, 50), "Normal"))
		{
			Debug.Log("Normal Button in Window " + wndID + " was clicked!");
		}
	}
	
	private void SecondWindowFunc(int wndID)
	{
		GUI.Box(new Rect(10, 50, 150, 50), "Window ID : " + wndID);
		
		if(GUI.Button(new Rect(10, 120, 150, 50), "Normal"))
		{
			Debug.Log("Normal Button in Window " + wndID + " was clicked!");
		}
	}
}
