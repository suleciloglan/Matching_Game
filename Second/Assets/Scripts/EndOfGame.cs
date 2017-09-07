using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EndOfGame : MonoBehaviour {

	public Text scoreText4;
	public Text scoreText3;
	public Text scoreText2;
	public Text scoreText1;
	
	public Canvas Star4;
	public Canvas Star3;
	public Canvas Star2;
	public Canvas Star1;

	public Sprite bg1; //bg3
	public Sprite bg2; //bg5
	public Sprite bg3; //bg1
	public Sprite bg4; //bg7

	private int level;

	public Image img;
	

	// Use this for initialization
	void Start () {

		Star4 = Star4.GetComponent<Canvas> ();
		Star3 = Star3.GetComponent<Canvas> ();
		Star2 = Star2.GetComponent<Canvas> ();
		Star1 = Star1.GetComponent<Canvas> ();
		scoreText4 = scoreText4.GetComponent<Text> ();
		scoreText3 = scoreText3.GetComponent<Text> ();
		scoreText2 = scoreText2.GetComponent<Text> ();
		scoreText1 = scoreText1.GetComponent<Text> ();

		Star3.enabled = false;
		Star4.enabled = false;
		Star2.enabled = false;
		Star1.enabled = false;

		scoreText1.enabled = false;
		scoreText2.enabled = false;
		scoreText3.enabled = false;
		scoreText4.enabled = false;




		putStars ();

	
	}
	
	public void putStars(){

		GameObject temp = GameObject.FindGameObjectWithTag("GameController");
		GameController3 level1 = temp.GetComponent<GameController3>();

		GameObject temp2 = GameObject.FindGameObjectWithTag("GameController");
		GameController level2 = temp2.GetComponent<GameController>();

		GameObject temp3 = GameObject.FindGameObjectWithTag("GameController");
		GameController4 level3 = temp3.GetComponent<GameController4>();

		GameObject temp4 = GameObject.FindGameObjectWithTag("GameController");
		GameController2 level4 = temp4.GetComponent<GameController2>();

		if (level1 != null) {
			/*Debug.Log("Level 1");
			Debug.Log("count: "+level1.countGuesses+" game "+ level1.gameGuesses);
            */
			level = level1.level;
			img.overrideSprite = bg1;
			if (level1.countGuesses >= level1.gameGuesses  && level1.countGuesses < level1.gameGuesses + 3) {

				Star3.enabled = false;
				Star4.enabled = true;
				Star2.enabled = false;
				Star1.enabled = false;
				scoreText4.enabled = true;
				scoreText4.text += level1.countGuesses;
		
			} else if (level1.countGuesses >= level1.gameGuesses + 3 && level1.countGuesses < level1.gameGuesses + 6) {
				
				Star3.enabled = true;
				Star4.enabled = false;
				Star2.enabled = false;
				Star1.enabled = false;
				scoreText3.enabled = true;
				scoreText3.text += level1.countGuesses;
				
			} else if (level1.countGuesses >= level1.gameGuesses + 6  && level1.countGuesses < level1.gameGuesses + 8 ) {
				
				Star3.enabled = false;
				Star4.enabled = false;
				Star2.enabled = true;
				Star1.enabled = false;
				scoreText2.enabled = true;
				scoreText2.text += level1.countGuesses;
				
			}
			else if (level1.countGuesses >= level1.gameGuesses + 8 )
			{
				Star3.enabled = false;
				Star4.enabled = false;
				Star2.enabled = false;
				Star1.enabled = true;
				scoreText1.enabled = true;
				scoreText1.text += level1.countGuesses;

			}


		} else if (level2 != null) {
			/*Debug.Log("Level 2");
			Debug.Log("count: "+level2.countGuesses+" game "+ level2.gameGuesses);
*/
			img.overrideSprite = bg2;

			level = level2.level;

			if (level2.countGuesses >= level2.gameGuesses  && level2.countGuesses < level2.gameGuesses + 3) {
				
				Star3.enabled = false;
				Star4.enabled = true;
				Star2.enabled = false;
				Star1.enabled = false;
				scoreText4.enabled = true;
				scoreText4.text += level2.countGuesses;
				
			} else if (level2.countGuesses >= level2.gameGuesses + 3 && level2.countGuesses < level2.gameGuesses + 6) {
				
				Star3.enabled = true;
				Star4.enabled = false;
				Star2.enabled = false;
				Star1.enabled = false;
				scoreText3.enabled = true;
				scoreText3.text += level2.countGuesses;
				
			} else if (level2.countGuesses >= level2.gameGuesses + 6 && level2.countGuesses < level2.gameGuesses + 8) {
				
				Star3.enabled = false;
				Star4.enabled = false;
				Star2.enabled = true;
				Star1.enabled = false;
				scoreText2.enabled = true;
				scoreText2.text += level3.countGuesses;
				
			}else if (level2.countGuesses >= level2.gameGuesses + 8 )
			{
				Star3.enabled = false;
				Star4.enabled = false;
				Star2.enabled = false;
				Star1.enabled = true;
				scoreText1.enabled = true;
				scoreText1.text += level2.countGuesses;

			}

		} else if (level3 !=null) {
			/*Debug.Log("Level 3");
			Debug.Log("count: "+level3.countGuesses+" game "+ level3.gameGuesses);
			*/
			img.overrideSprite = bg3;
			level = level3.level;
			if (level3.countGuesses >= level3.gameGuesses  && level3.countGuesses < level3.gameGuesses + 3) {
			
				Star3.enabled = false;
				Star4.enabled = true;
				Star2.enabled = false;
				Star1.enabled = false;
				scoreText4.enabled = true;
				scoreText4.text += level3.countGuesses;
			
			} else if (level3.countGuesses >= level3.gameGuesses + 3 && level3.countGuesses < level3.gameGuesses + 6) {
			
				Star3.enabled = true;
				Star4.enabled = false;
				Star2.enabled = false;
				Star1.enabled = false;
				scoreText3.enabled = true;
				scoreText3.text += level3.countGuesses;
			
			} else if (level3.countGuesses >= level3.gameGuesses + 6 && level3.countGuesses < level3.gameGuesses + 8) {
			
				Star3.enabled = false;
				Star4.enabled = false;
				Star2.enabled = true;
				Star1.enabled = false;
				scoreText2.enabled = true;
				scoreText2.text += level3.countGuesses;
			
			}else if(level3.countGuesses >= level3.gameGuesses + 8)
			{
				Star3.enabled = false;
				Star4.enabled = false;
				Star2.enabled = false;
				Star1.enabled = true;
				scoreText1.enabled = true;
				scoreText1.text += level3.countGuesses;
			}

		} else if (level4 !=null) {
			/*Debug.Log("Level 4");
			Debug.Log("count: "+level4.countGuesses+" game "+ level4.gameGuesses);
			*/
			img.overrideSprite = bg4;
			level = level4.level;
			if (level4.countGuesses >= level4.gameGuesses  && level4.countGuesses < level4.gameGuesses + 3) {
				
				Star3.enabled = false;
				Star4.enabled = true;
				Star2.enabled = false;
				Star1.enabled = false;
				scoreText4.enabled = true;
				scoreText4.text += level4.countGuesses;
				
			} else if (level4.countGuesses >= level4.gameGuesses + 3 && level4.countGuesses < level4.gameGuesses + 6) {
				
				Star3.enabled = true;
				Star4.enabled = false;
				Star2.enabled = false;
				Star1.enabled = false;
				scoreText3.enabled = true;
				scoreText3.text += level4.countGuesses;
				
			} else if (level4.countGuesses >= level4.gameGuesses + 6 && level4.countGuesses < level4.gameGuesses + 8) {
				
				Star3.enabled = false;
				Star4.enabled = false;
				Star2.enabled = true;
				Star1.enabled = false;
				scoreText2.enabled = true;
				scoreText2.text += level4.countGuesses;
				
			}
			else if(level4.countGuesses >= level4.gameGuesses + 8)
			{
				Star3.enabled = false;
				Star4.enabled = false;
				Star2.enabled = false;
				Star1.enabled = true;
				scoreText1.enabled = true;
				scoreText1.text += level4.countGuesses;


			}
		}
		Destroy (temp);
		Destroy (temp2);
		Destroy (temp3);
		Destroy (temp4);

	}

	public void checkButton1()  // Back button
	{
		if (level == 1) {
			StartLevel1 ();

		} else if (level == 2) {
			StartLevel2();
		}else if (level == 3) {
			StartLevel3();
		}
		else if (level == 4) {
			StartLevel4();
		}
	}



	public void StartLevel2 () //this function will be used on our Play button	
	{
		Application.LoadLevel (2); //this will load our first level from our build settings. "1" is the second scene in our game
		
	}
	public void StartLevel0 () //this function will be used on our Play button	
	{
		Application.LoadLevel (0); //this will load our first level from our build settings. "1" is the second scene in our game
		
	}
	public void StartLevel3()
	{
		Application.LoadLevel (3);
	}
	public void StartLevel4()
	{
		Application.LoadLevel (4);
	}
	public void StartLevel1()
	{
		Application.LoadLevel (1);
	}
}
