using UnityEngine;
using System.Collections;
using UnityEngine.UI;// we need this namespace in order to access UI elements within our script

public class MenuController : MonoBehaviour {



	/*******************************/
	public Canvas quitMenu;
	public Canvas helpMenu;
	public Button level1;
	public Button level2;
	public Button level3;
	public Button level4;
	public Button help;
	public Button exit;

	void Start ()
	{
		quitMenu = quitMenu.GetComponent<Canvas>();
		helpMenu = helpMenu.GetComponent<Canvas> ();
		level1 = level1.GetComponent<Button> ();
		level2 = level2.GetComponent<Button> ();
		level3 = level3.GetComponent<Button> ();
		level4 = level4.GetComponent<Button> ();
		exit = exit.GetComponent<Button> ();
		help = help.GetComponent<Button> ();

		
		quitMenu.enabled = false;
		helpMenu.enabled = false;


	}


	public void ExitPress() //this function will be used on our Exit button
		
	{
		quitMenu.enabled = true; //enable the Quit menu when we click the Exit button
		helpMenu.enabled = false;
		level1.enabled = false; //then disable the Play and Exit buttons so they cannot be clicked
		level2.enabled = false; //then disable the Play and Exit buttons so they cannot be clicked
		level3.enabled = false;
		level4.enabled = false;
		help.enabled = false;
		exit.enabled = false;
		
	}
	
	public void NoPress() //this function will be used for our "NO" button in our Quit Menu
		
	{
		quitMenu.enabled = false; //we'll disable the quit menu, meaning it won't be visible anymore
		helpMenu.enabled = false;
		level1.enabled = true; //then disable the Play and Exit buttons so they cannot be clicked
		level2.enabled = true; //then disable the Play and Exit buttons so they cannot be clicked
		level3.enabled = true;
		level4.enabled = true;
		help.enabled = true;
		exit.enabled = true;
		
	}
	
	public void StartLevel1 () //this function will be used on our Play button
		
	{
		Application.LoadLevel (1); //this will load our first level from our build settings. "1" is the second scene in our game
		
	}
	public void StartLevel2 () //this function will be used on our Play button
		
	{
		Application.LoadLevel (2); //this will load our first level from our build settings. "1" is the second scene in our game
		
	}
	public void StartLevel3 () //this function will be used on our Play button
		
	{
		Application.LoadLevel (3); //this will load our first level from our build settings. "1" is the second scene in our game
		
	}
	public void StartLevel4 () //this function will be used on our Play button
		
	{
		Application.LoadLevel (4); //this will load our first level from our build settings. "1" is the second scene in our game
		
	}
	
	public void Help () //this function will be used on our Play button
		
	{
		helpMenu.enabled = true;
		quitMenu.enabled = false; //enable the Quit menu when we click the Exit button
		level1.enabled = false; //then disable the Play and Exit buttons so they cannot be clicked
		level2.enabled = false; //then disable the Play and Exit buttons so they cannot be clicked
		level3.enabled = false;
		level4.enabled = false;
		help.enabled = false;
		exit.enabled = false;
	}
	
	public void ExitGame () //This function will be used on our "Yes" button in our Quit menu
		
	{
		Application.Quit(); //this will quit our game. Note this will only work after building the game
		
	}

	
}

