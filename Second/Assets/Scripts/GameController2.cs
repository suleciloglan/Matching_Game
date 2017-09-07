using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class GameController2 : MonoBehaviour {

	[SerializeField]
	private Sprite bgImage;
	[SerializeField]
	private Sprite bgImage2;
	[SerializeField]
	private Sprite bgImage3;
	[SerializeField]
	private Sprite bgImage4;
	[SerializeField]
	private Sprite bgImage5;
	[SerializeField]
	private Sprite bgImage6;
	[SerializeField]
	private Sprite bgImage7;

	public  int level = 4;
	
	public Sprite[] puzzles;
	public List<Sprite> gamePuzzles = new List<Sprite> ();
	
	public List <Button> btns = new List<Button>(); 
	
	
	private bool firstGuess, secondGuess;
	public  int countGuesses;
	private int countCorrectGuesses;
	public  int gameGuesses;
	
	private int firstGuessIndex, secondGuessIndex;
	
	private string firstGuessPuzzle, secondGuessPuzzle;
	
	
	
	void Start(){
		GetButtons ();
		AddListeners();
		AddGamePuzzles ();
		Shuffle (gamePuzzles);
		gameGuesses = gamePuzzles.Count / 2;

	}
	void Awake()
	{
		DontDestroyOnLoad (this);
		level = Application.loadedLevel;
	}
	void GetButtons(){
		
		GameObject[] objects = GameObject.FindGameObjectsWithTag ("PuzzleButton");
		
		for (int i = 0; i< objects.Length; ++i) {
			
			btns.Add(objects[i].GetComponent<Button>());
			
			//btns[i].image.sprite = bgImage5;
			
		}
		btns[0].image.sprite = bgImage;
		btns[1].image.sprite = bgImage2;
		btns[2].image.sprite = bgImage3;
		btns[3].image.sprite = bgImage4;
		btns[4].image.sprite = bgImage5;
		btns[5].image.sprite = bgImage6;
		btns[6].image.sprite = bgImage7;
		btns[7].image.sprite = bgImage5;
		btns[8].image.sprite = bgImage;
		btns[9].image.sprite = bgImage2;
		btns[10].image.sprite = bgImage3;
		btns[11].image.sprite = bgImage4;
		btns[12].image.sprite = bgImage5;
		btns[13].image.sprite = bgImage6;
		btns[14].image.sprite = bgImage7;
		btns[15].image.sprite = bgImage5;
		btns[16].image.sprite = bgImage;
		btns[17].image.sprite = bgImage2;
		btns[18].image.sprite = bgImage3;
		btns[19].image.sprite = bgImage4;


	}
	
	void AddGamePuzzles(){
		
		int looper = btns.Count;
		int index = 0;
		
		for (int i = 0; i<looper; ++i) {
			
			if(index == looper/2){
				
				index = 0;
			}
			gamePuzzles.Add(puzzles[index]);
			++index;
		}
		
		
	}
	
	void AddListeners(){
		foreach (Button btn in btns) {
			btn.onClick.AddListener(() =>PickAPuzzle());
		}
		
	}
	public void PickAPuzzle(){
		
		string name = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name;
		
		
		
		if (!firstGuess) {
			firstGuess = true;
			firstGuessIndex = int.Parse(name);
			
			firstGuessPuzzle = gamePuzzles[firstGuessIndex].name;
			btns[firstGuessIndex].image.sprite = gamePuzzles[firstGuessIndex];
			
		} else if (!secondGuess) {
			
			secondGuess = true;
			secondGuessIndex = int.Parse(name);
			
			
			secondGuessPuzzle = gamePuzzles[secondGuessIndex].name;
			btns[secondGuessIndex].image.sprite = gamePuzzles[secondGuessIndex];
			
			++countGuesses;
			
			StartCoroutine(CheckIfThePuzzlesMatch());
			
			
		}
		
	}
	
	
	
	IEnumerator CheckIfThePuzzlesMatch(){
		
		yield return new WaitForSeconds(0.5f);
		
		if (btns [firstGuessIndex].name != btns [secondGuessIndex].name) {
			if (firstGuessPuzzle == secondGuessPuzzle) {
			
				yield return new WaitForSeconds (.25f);
				btns [firstGuessIndex].interactable = false;
				btns [secondGuessIndex].interactable = false;
			
			
				btns [firstGuessIndex].image.color = new Color (0, 0, 0, 0);
				btns [secondGuessIndex].image.color = new Color (0, 0, 0, 0);
			
				CheckIfTheGameIsFinished ();
			
			} else {
			
				yield return new WaitForSeconds (.5f);
				if (firstGuessIndex == 0)
					btns [firstGuessIndex].image.sprite = bgImage;
				else if (firstGuessIndex == 1)
					btns [firstGuessIndex].image.sprite = bgImage2;
				else if (firstGuessIndex == 2)
					btns [firstGuessIndex].image.sprite = bgImage3;
				else if (firstGuessIndex == 3)
					btns [firstGuessIndex].image.sprite = bgImage4;
				else if (firstGuessIndex == 4) 
					btns [firstGuessIndex].image.sprite = bgImage5;
				else if (firstGuessIndex == 5) 
					btns [firstGuessIndex].image.sprite = bgImage6;
				else if (firstGuessIndex == 6)
					btns [firstGuessIndex].image.sprite = bgImage7;
				else if (firstGuessIndex == 7)
					btns [firstGuessIndex].image.sprite = bgImage5;
				else if (firstGuessIndex == 8)
					btns [firstGuessIndex].image.sprite = bgImage2;
				else if (firstGuessIndex == 9)
					btns [firstGuessIndex].image.sprite = bgImage3;
				else if (firstGuessIndex == 10)
					btns [firstGuessIndex].image.sprite = bgImage4;
				else if (firstGuessIndex == 11) 
					btns [firstGuessIndex].image.sprite = bgImage5;
				else if (firstGuessIndex == 12) 
					btns [firstGuessIndex].image.sprite = bgImage6;
				else if (firstGuessIndex == 13)
					btns [firstGuessIndex].image.sprite = bgImage7;
				else if (firstGuessIndex == 14)
					btns [firstGuessIndex].image.sprite = bgImage5;
				else if (firstGuessIndex == 15)
					btns [firstGuessIndex].image.sprite = bgImage2;
				else if (firstGuessIndex == 16)
					btns [firstGuessIndex].image.sprite = bgImage3;
				else if (firstGuessIndex == 17)
					btns [firstGuessIndex].image.sprite = bgImage4;
				else if (firstGuessIndex == 18) 
					btns [firstGuessIndex].image.sprite = bgImage5;
				else if (firstGuessIndex == 19) 
					btns [firstGuessIndex].image.sprite = bgImage6;

			
			
				if (secondGuessIndex == 0)
					btns [secondGuessIndex].image.sprite = bgImage;
				else if (secondGuessIndex == 1)
					btns [secondGuessIndex].image.sprite = bgImage2;
				else if (secondGuessIndex == 2)
					btns [secondGuessIndex].image.sprite = bgImage3;
				else if (secondGuessIndex == 3)
					btns [secondGuessIndex].image.sprite = bgImage4;
				else if (secondGuessIndex == 4) 
					btns [secondGuessIndex].image.sprite = bgImage5;
				else if (secondGuessIndex == 5) 
					btns [secondGuessIndex].image.sprite = bgImage6;
				else if (secondGuessIndex == 6)
					btns [secondGuessIndex].image.sprite = bgImage7;
				else if (secondGuessIndex == 7)
					btns [secondGuessIndex].image.sprite = bgImage5;
				else if (secondGuessIndex == 8)
					btns [secondGuessIndex].image.sprite = bgImage2;
				else if (secondGuessIndex == 9)
					btns [secondGuessIndex].image.sprite = bgImage3;
				else if (secondGuessIndex == 10)
					btns [secondGuessIndex].image.sprite = bgImage4;
				else if (secondGuessIndex == 11) 
					btns [secondGuessIndex].image.sprite = bgImage5;
				else if (secondGuessIndex == 12) 
					btns [secondGuessIndex].image.sprite = bgImage6;
				else if (secondGuessIndex == 13)
					btns [secondGuessIndex].image.sprite = bgImage7;
				else if (secondGuessIndex == 14)
					btns [secondGuessIndex].image.sprite = bgImage5;
				else if (secondGuessIndex == 15)
					btns [secondGuessIndex].image.sprite = bgImage2;
				else if (secondGuessIndex == 16)
					btns [secondGuessIndex].image.sprite = bgImage3;
				else if (secondGuessIndex == 17)
					btns [secondGuessIndex].image.sprite = bgImage4;
				else if (secondGuessIndex == 18) 
					btns [secondGuessIndex].image.sprite = bgImage5;
				else if (secondGuessIndex == 19) 
					btns [secondGuessIndex].image.sprite = bgImage6;


			
			}

		} else {
			if (firstGuessIndex == 0)
				btns [firstGuessIndex].image.sprite = bgImage;
			else if (firstGuessIndex == 1)
				btns [firstGuessIndex].image.sprite = bgImage2;
			else if (firstGuessIndex == 2)
				btns [firstGuessIndex].image.sprite = bgImage3;
			else if (firstGuessIndex == 3)
				btns [firstGuessIndex].image.sprite = bgImage4;
			else if (firstGuessIndex == 4) 
				btns [firstGuessIndex].image.sprite = bgImage5;
			else if (firstGuessIndex == 5) 
				btns [firstGuessIndex].image.sprite = bgImage6;
			else if (firstGuessIndex == 6)
				btns [firstGuessIndex].image.sprite = bgImage7;
			else if (firstGuessIndex == 7)
				btns [firstGuessIndex].image.sprite = bgImage5;
			else if (firstGuessIndex == 8)
				btns [firstGuessIndex].image.sprite = bgImage2;
			else if (firstGuessIndex == 9)
				btns [firstGuessIndex].image.sprite = bgImage3;
			else if (firstGuessIndex == 10)
				btns [firstGuessIndex].image.sprite = bgImage4;
			else if (firstGuessIndex == 11) 
				btns [firstGuessIndex].image.sprite = bgImage5;
			else if (firstGuessIndex == 12) 
				btns [firstGuessIndex].image.sprite = bgImage6;
			else if (firstGuessIndex == 13)
				btns [firstGuessIndex].image.sprite = bgImage7;
			else if (firstGuessIndex == 14)
				btns [firstGuessIndex].image.sprite = bgImage5;
			else if (firstGuessIndex == 15)
				btns [firstGuessIndex].image.sprite = bgImage2;
			else if (firstGuessIndex == 16)
				btns [firstGuessIndex].image.sprite = bgImage3;
			else if (firstGuessIndex == 17)
				btns [firstGuessIndex].image.sprite = bgImage4;
			else if (firstGuessIndex == 18) 
				btns [firstGuessIndex].image.sprite = bgImage5;
			else if (firstGuessIndex == 19) 
				btns [firstGuessIndex].image.sprite = bgImage6;
			
			
			
			if (secondGuessIndex == 0)
				btns [secondGuessIndex].image.sprite = bgImage;
			else if (secondGuessIndex == 1)
				btns [secondGuessIndex].image.sprite = bgImage2;
			else if (secondGuessIndex == 2)
				btns [secondGuessIndex].image.sprite = bgImage3;
			else if (secondGuessIndex == 3)
				btns [secondGuessIndex].image.sprite = bgImage4;
			else if (secondGuessIndex == 4) 
				btns [secondGuessIndex].image.sprite = bgImage5;
			else if (secondGuessIndex == 5) 
				btns [secondGuessIndex].image.sprite = bgImage6;
			else if (secondGuessIndex == 6)
				btns [secondGuessIndex].image.sprite = bgImage7;
			else if (secondGuessIndex == 7)
				btns [secondGuessIndex].image.sprite = bgImage5;
			else if (secondGuessIndex == 8)
				btns [secondGuessIndex].image.sprite = bgImage2;
			else if (secondGuessIndex == 9)
				btns [secondGuessIndex].image.sprite = bgImage3;
			else if (secondGuessIndex == 10)
				btns [secondGuessIndex].image.sprite = bgImage4;
			else if (secondGuessIndex == 11) 
				btns [secondGuessIndex].image.sprite = bgImage5;
			else if (secondGuessIndex == 12) 
				btns [secondGuessIndex].image.sprite = bgImage6;
			else if (secondGuessIndex == 13)
				btns [secondGuessIndex].image.sprite = bgImage7;
			else if (secondGuessIndex == 14)
				btns [secondGuessIndex].image.sprite = bgImage5;
			else if (secondGuessIndex == 15)
				btns [secondGuessIndex].image.sprite = bgImage2;
			else if (secondGuessIndex == 16)
				btns [secondGuessIndex].image.sprite = bgImage3;
			else if (secondGuessIndex == 17)
				btns [secondGuessIndex].image.sprite = bgImage4;
			else if (secondGuessIndex == 18) 
				btns [secondGuessIndex].image.sprite = bgImage5;
			else if (secondGuessIndex == 19) 
				btns [secondGuessIndex].image.sprite = bgImage6;



			btns [firstGuessIndex].interactable = true;
			btns [secondGuessIndex].interactable = true;
		
		}
		yield return new WaitForSeconds (.5f);
		firstGuess = secondGuess = false;
		
	}
	void Shuffle(List<Sprite> list){
		
		for (int i=0; i<list.Count; ++i) {
			
			Sprite temp = list[i];
			int randomIndex = Random.Range(0,list.Count);
			list[i] = list[randomIndex];
			list[randomIndex] = temp;
		}
	}
	
	void CheckIfTheGameIsFinished(){
		
		countCorrectGuesses++;
		if (countCorrectGuesses == gameGuesses) {

			Application.LoadLevel(5);
			/*Debug.Log ("Game Finished");
			Debug.Log ("It took you "+ countGuesses+" many guess(es) to finish the game");
			*/
		}
	}

	public void StartLevel0 () //this function will be used on our Play button	
	{
		Destroy (this);
		Application.LoadLevel (0); //this will load our first level from our build settings. "1" is the second scene in our game
		
	}
}
