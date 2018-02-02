using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamePlayController : MonoBehaviour {

	public static GamePlayController instance;

	[SerializeField]
	private Button tapPlayButton, pauseButton;

	[SerializeField]
	private Text scoreText, endScoreText, bestScoreText;

	[SerializeField]
	private GameObject gameOverPanel, pausePanel;

	// Use this for initialization
	void Awake () {
		Time.timeScale = 0;
		gameOverPanel.SetActive (false);
		pausePanel.SetActive (false);
		_MakeInstance ();
	}

	void _MakeInstance() {
		if(instance == null) {
			instance = this;
		}
	}
	
	public void _TapPlayButton() {
		Time.timeScale = 1;
		tapPlayButton.gameObject.SetActive (false);
	}

	public void _SetScore(int score) {
		scoreText.text = "" + score;
	}

	public void _BirdDiedShowPanel() {
		gameOverPanel.SetActive (true);
	}

	public void _MenuButton() {
		Application.LoadLevel ("MainMenu");
	}

	public void _RestartGameButton() {
		Application.LoadLevel ("GamePlay");
		//Application.LoadLevel (Application.loadedLevel);
	}

	public void _PauseButton() {
		Time.timeScale = 0;
		pausePanel.gameObject.SetActive (false);
		pausePanel.SetActive (true);
	}

	public void _ResumeButton() {
		Time.timeScale = 1;
		pausePanel.gameObject.SetActive (true);
		pausePanel.SetActive (false);
	}
}
