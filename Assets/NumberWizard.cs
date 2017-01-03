using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NumberWizard : MonoBehaviour {
	int max;
	int min;
	int guess;
	public int maxGuesses = 5;
	public Text text;
	 
	// Use this for initialization
	void Start () {
		StartGame();
	}


	public void GuessLower ()
	{
		max = guess;
		NextGuess();
	}

	public void GuessHigher ()
	{
		min = guess;
		NextGuess();
	}

	void StartGame () {
		max = 1000;
		min = 1;
		guess = Random.Range(min, max);
		text.text = guess.ToString();
	}

	void NextGuess () {
		guess = Random.Range(min, max + 1);
		text.text = guess.ToString();
		maxGuesses = maxGuesses - 1;

		if (maxGuesses <= 0) {
			SceneManager.LoadScene("Win");
//			Application.LoadLevel("Win");
		}
	}
}
