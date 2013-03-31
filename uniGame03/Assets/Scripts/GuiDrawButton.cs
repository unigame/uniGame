using UnityEngine;
using System.Collections;

public class GuiDrawButton : MonoBehaviour {
	
	/// <summary>
	/// The button texture.
	/// </summary>
	public Texture2D btnTexture;
	
	/// <summary>
	/// The message.
	/// </summary>
	private string msg = string.Empty;
	
	/// <summary>
	/// The frame time.
	/// </summary>
	private int frameTime = 0;
	
	// Use this for initialization
	void Start () {
	
		// init
		msg = "Pls Click the button";
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	// Draw GUI
	void OnGUI(){
		
		// show the message	
		GUI.Label(new Rect(10, 10, Screen.width, 30), msg);
		
		if(GUI.Button(new Rect(10, 50, btnTexture.width, btnTexture.height), btnTexture)){
			
			// click the button and changed the message
			msg = "Woow...You clicked!";
		}
		
		// set the color for button
		GUI.color = Color.green;
		
		// set the backgroud
		GUI.backgroundColor = Color.red;
		
		if(GUI.RepeatButton(new Rect(300, 200, 100, 30), "Clicking...")){
			
			// change the message
			msg = "You had clicked : " + frameTime;
			
			frameTime ++ ;
		}
	}
}
