using UnityEngine;
using System.Collections;

public class AddButtons3 : MonoBehaviour {

	[SerializeField]
	private Transform puzzleField;
	
	[SerializeField]
	private GameObject button;
	
	void Awake()
	{
		for (int  i=0; i<6; ++i) {
			
			GameObject btn = Instantiate(button); // makes a copy of buttons
			btn.name = "" +i;
			btn.transform.SetParent(puzzleField,false);
		}
		
		
		
	}
}
