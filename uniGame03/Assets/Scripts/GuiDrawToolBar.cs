using UnityEngine;
using System.Collections;

public class GuiDrawToolBar : MonoBehaviour 
{
	/// <summary>
	/// The selected id
	/// </summary>
	private int selected = 0;
	
	/// <summary>
	/// The bar resources.
	/// </summary>
	private string [] barResources ;
	
	
	private bool selectToggle0 = false;
	private bool selectToggle1 = false;
	
	// Use this for initialization
	void Start () 
	{
		// Init
		selected = 0;
		barResources = new string[]{"First", "Second", "Third", "Forth"};
		
		selectToggle0 = false;
		selectToggle1 = false;
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
	
	void OnGUI()
	{
		// backup the old selected id
		int oldID = selected;
		
		// get the selected id
		selected = GUI.Toolbar(new Rect(10, 10, barResources.Length * 100, 30), selected, barResources);
		
		// update the status of Toggle, if it select different bar
		if(oldID != selected)
		{
			selectToggle0 = false;
			selectToggle1 = false;
		}
		
		switch(selected)
		{
		case 0:
			selectToggle0 = GUI.Toggle(new Rect(10, 50, 150, 30), selectToggle0, "First -> 01");
			selectToggle1 = GUI.Toggle(new Rect(10, 100, 150, 30), selectToggle1, "First -> 02");
			break;
			
		case 1:
			selectToggle0 = GUI.Toggle(new Rect(10, 50, 150, 30), selectToggle0, "Second -> 01");
			selectToggle1 = GUI.Toggle(new Rect(10, 100, 150, 30), selectToggle1, "Second -> 02");
			break;
			
		case 2:
			selectToggle0 = GUI.Toggle(new Rect(10, 50, 150, 30), selectToggle0, "Third -> 01");
			selectToggle1 = GUI.Toggle(new Rect(10, 100, 150, 30), selectToggle1, "Third -> 02");
			break;
			
		case 3:
			selectToggle0 = GUI.Toggle(new Rect(10, 50, 150, 30), selectToggle0, "Forth -> 01");
			selectToggle1 = GUI.Toggle(new Rect(10, 100, 150, 30), selectToggle1, "Forth -> 02");
			break;
			
		default:
			break;
		}
	}
}
