using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gamecontroller : MonoBehaviour {
	public Text hintText;
	public InputField inputField;
	public Text levelText;


	// normal val
	public string levelAnswer;
	public string levelNumber;
	public string levelHint;
	public string nextScene;

	// Use this for initialization
	void Start () {
		hintText.text = levelHint;
		
	}
	public void CheckAnswer(){
		if (inputField.text == levelAnswer) {
			hintText.text = "yay";
			hintText.color = Color.green;
			SceneManager.LoadScene (nextScene);
		} else {
			hintText.text = "access denied";
			hintText.color = Color.red;
			inputField.text = "";
			inputField.ActivateInputField ();
		}
	}
	// Update is called once per frame
	void Update () {
		
	}
}
