using UnityEngine;
using System.Collections;

public class GuiDrawGroupView : MonoBehaviour 
{
	public Texture2D first;
	public Texture2D second;
		
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
		// first group view
		GUI.BeginGroup(new Rect(20, 20, first.width, first.height), first);
		
		GUI.Label(new Rect(20, 20, 100, 30), "First Group View");
		GUI.Button(new Rect(20, 100, 100, 30), "Button In First");
		
		GUI.EndGroup();
		
				// first group view
		GUI.BeginGroup(new Rect(600, 20, second.width, second.height), second);
		
		GUI.Label(new Rect(20, 60, 150, 30), "second Group View");
		GUI.Button(new Rect(20, 160, 150, 30), "Button In second");
		
		GUI.EndGroup();
	}
}
