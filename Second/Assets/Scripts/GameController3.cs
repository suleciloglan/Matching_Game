using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class GameController3 : MonoBehaviour {
	
	public  int level = 1;

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
					btns [firstGuessIndex].image.sprite = gamePuzzles [0];
				else if (firstGuessIndex == 1)
					btns [firstGuessIndex].image.sprite = gamePuzzles [1];
				else if (firstGuessIndex == 2)
					btns [firstGuessIndex].image.sprite = gamePuzzles [2];
				else if (firstGuessIndex == 3)
					btns [firstGuessIndex].image.sprite = gamePuzzles [3];
				else if (firstGuessIndex == 4) 
					btns [firstGuessIndex].image.sprite = gamePuzzles [4];
				else if (firstGuessIndex == 5) 
					btns [firstGuessIndex].image.sprite = gamePuzzles [5];
		
			
			
				if (secondGuessIndex == 0)
					btns [secondGuessIndex].image.sprite = gamePuzzles [0];
				else if (secondGuessIndex == 1)
					btns [secondGuessIndex].image.sprite = gamePuzzles [1];
				else if (secondGuessIndex == 2)
					btns [secondGuessIndex].image.sprite = gamePuzzles [2];
				else if (secondGuessIndex == 3)
					btns [secondGuessIndex].image.sprite = gamePuzzles [3];
				else if (secondGuessIndex == 4) 
					btns [secondGuessIndex].image.sprite = gamePuzzles [4];
				else if (secondGuessIndex == 5) 
					btns [secondGuessIndex].image.sprite = gamePuzzles [5];


			
			}
		} else {
		
			if (firstGuessIndex == 0)
				btns [firstGuessIndex].image.sprite = gamePuzzles [0];
			else if (firstGuessIndex == 1)
				btns [firstGuessIndex].image.sprite = gamePuzzles [1];
			else if (firstGuessIndex == 2)
				btns [firstGuessIndex].image.sprite = gamePuzzles [2];
			else if (firstGuessIndex == 3)
				btns [firstGuessIndex].image.sprite = gamePuzzles [3];
			else if (firstGuessIndex == 4) 
				btns [firstGuessIndex].image.sprite = gamePuzzles [4];
			else if (firstGuessIndex == 5) 
				btns [firstGuessIndex].image.sprite = gamePuzzles [5];
			
			
			
			if (secondGuessIndex == 0)
				btns [secondGuessIndex].image.sprite = gamePuzzles [0];
			else if (secondGuessIndex == 1)
				btns [secondGuessIndex].image.sprite = gamePuzzles [1];
			else if (secondGuessIndex == 2)
				btns [secondGuessIndex].image.sprite = gamePuzzles [2];
			else if (secondGuessIndex == 3)
				btns [secondGuessIndex].image.sprite = gamePuzzles [3];
			else if (secondGuessIndex == 4) 
				btns [secondGuessIndex].image.sprite = gamePuzzles [4];
			else if (secondGuessIndex == 5) 
				btns [secondGuessIndex].image.sprite = gamePuzzles [5];

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
		for (int i=0; i<list.Count; ++i) {
		
			btns[i].image.sprite = list[i];	
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
