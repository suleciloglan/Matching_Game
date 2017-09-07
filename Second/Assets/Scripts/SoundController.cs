using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SoundController : MonoBehaviour {

	public Sprite Texture1;
	public Sprite Texture2;

	public GameObject audioSource;

	public Button btn;
	public Image image;
	private bool soundToggle = true;

	

	void Awake() {

		btn.onClick.AddListener (() => isPressed ());

	}

	public void isPressed()
	{
		soundToggle = !soundToggle;

	
		if (soundToggle) {
			audioSource.SetActive (true);
			image.overrideSprite  = Texture1;
		} else {
			audioSource.SetActive (false);
			image.overrideSprite  = Texture2;
		}



	}
}
