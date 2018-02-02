using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public static GameManager instance;

	private const string HIGH_SCORE = "High Score";

	// Use this for initialization
	void Awake () {
		_MakeSingleInstance ();
	}

	void _MakeSingleInstance() {
		if (instance != null) {
			Destroy (gameObject);
		} else {
			instance = this;
			DontDestroyOnLoad (gameObject);
		}
	}

	public void _SetHighScore(int score) {
		PlayerPrefs.SetInt (HIGH_SCORE, score);
	}

	public int _GetHighScore() {
		return PlayerPrefs.GetInt (HIGH_SCORE);
	}
}
