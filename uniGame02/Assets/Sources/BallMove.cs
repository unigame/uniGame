using UnityEngine;
using System.Collections;

public class BallMove : MonoBehaviour 
{
	/// <summary>
	/// The rotate speed.
	/// </summary>
	private int rotateSpeed = 5000;
	
	/// <summary>
	/// The translate speed.
	/// </summary>
	private int translateSpeed = 20;
	
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
	
	// Draw GUI
	void OnGUI()
	{
		GUI.backgroundColor = Color.red;
		
		if(GUI.Button(new Rect(20, 20, 130, 40), new GUIContent("Rotate to the Left")))
		{
			// Transform
			transform.Rotate(Vector3.left * Time.deltaTime * rotateSpeed, Space.Self);
		}
		
		if(GUI.Button(new Rect(170, 20, 130, 40), new GUIContent("Rotate to the Right")))
		{
			// Transform
			transform.Rotate(Vector3.right * Time.deltaTime * (rotateSpeed), Space.Self);
		}
		
		if(GUI.Button(new Rect(310, 20, 130, 40), new GUIContent("Move forward")))
		{
			// Translate
			transform.Translate(Vector3.forward * Time.deltaTime * translateSpeed, Space.World);
		}
		
		if(GUI.Button(new Rect(20, 60, 130, 40), new GUIContent("Move backward")))
		{
			// Translate
			transform.Translate (Vector3.back * Time.deltaTime * (translateSpeed), Space.World);
		}
		
		
	}
}
