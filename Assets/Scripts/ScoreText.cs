using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreText : MonoBehaviour
{
    public int score = 0;
    public TMP_Text scoreText;
	public TMP_Text maxScoreText;
	private void Start()
	{
		maxScoreText.text += LoadScore().ToString();
	}
	private void Update()
	{
		scoreText.text = score.ToString();
	}
	int LoadScore()
	{
		return PlayerPrefs.GetInt("HighScore", 0);
	}
}
