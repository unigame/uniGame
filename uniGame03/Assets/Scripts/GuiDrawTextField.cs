using UnityEngine;
using System.Collections;

public class GuiDrawTextField : MonoBehaviour 
{
	
	private string editUserName = string.Empty;
	
	private string editPassword = string.Empty;
	
	private string editShow = string.Empty;
	
	// Use this for initialization
	void Start () 
	{
		editShow = "Pls input your username and password.";
		editUserName = "Pls input your uername";
		editPassword = "Pls input your password";
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
	
	void OnGUI()
	{
		GUI.Label(new Rect(20, 20, Screen.width, 30), editShow);
		
		GUI.Label(new Rect(20, 60, 80, 30), "UserName:");
		editUserName = GUI.TextField(new Rect(100, 60, 160, 30), editUserName);
		
		GUI.Label(new Rect(20, 100, 80, 30), "Password:");
		editPassword = GUI.PasswordField(new Rect(100, 100, 160, 30), editPassword, "*"[0]);
		
		if(GUI.Button(new Rect(20, 160, 100, 50), "Login"))
		{
			// click and login
			editShow = "Your UserName is " + editUserName + 
					   "  and your password is " + editPassword;
		}
	}
}
