using UnityEngine;
using System.Collections;

public class BallMove : MonoBehaviour 
{
	/// <summary>
	/// The rotate speed.
	/// </summary>
	private int rotateSpeed = 6000;
	
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
		if(GUI.Button(new Rect(20, 20, 100, 40), new GUIContent("Just Do it")))
		{
			// Transform
			transform.Rotate(Vector3.up * Time.deltaTime * (-rotateSpeed));
		}
	}
}
