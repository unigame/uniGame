using UnityEngine;
using System.Collections;

public class GUIDraw01 : MonoBehaviour {
	
	/// <summary>
	/// Gets or sets the string message.
	/// </summary>
	/// <value>
	/// The string message.
	/// </value>
	public string strMessage;
	
	/// <summary>
	/// Gets or sets the image texture.
	/// </summary>
	/// <value>
	/// The image texture.
	/// </value>
	public Texture imgTexture ;
	
	private int imgWidth = 0;
	private int imgHeight = 0;
	
	private int screenWidth = 0;
	private int screenHeight = 0;
	
	// Use this for initialization
	void Start (){
	
		// Get the resolution of Screen
		screenWidth = Screen.width;
		screenHeight = Screen.height;
		
		// Get the resolution of image
		imgWidth = imgTexture.width;
		imgHeight = imgTexture.height;
	}
	
	// Update is called once per frame
	void OnGUI () {
	
		//show 
		GUI.Label(new Rect(100, 10, 100, 30), strMessage);
		GUI.Label(new Rect(220, 10, 150, 30), "Screen Width : " + screenWidth);
		GUI.Label(new Rect(400, 10, 150, 30), "Screen Height : " + screenHeight);
		
		// show the texture
		GUI.Label(new Rect(100, 40, imgWidth, imgHeight), imgTexture);
	}
}
