using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Pin : MonoBehaviour
{
    private bool isPinned = false;
    public float speed = 50f;
    private ScoreText scoreScoreText;
	private Rotator Rotator;
	public Rigidbody2D Rigidbody2D;
	private void Start()
	{
		scoreScoreText = FindObjectOfType<ScoreText>();
        Rotator = FindObjectOfType<Rotator>();
	}
	void Update()
    {
        if (!isPinned)
        {
			Rigidbody2D.MovePosition(Rigidbody2D.position + Vector2.up * speed * Time.deltaTime);
		}
        
        
    }
	private void OnTriggerEnter2D(Collider2D collision)
	{
        Debug.Log(collision.name + collision.tag);
		if (collision.CompareTag("Rotator") ){ 
            transform.SetParent(collision.transform);
            scoreScoreText.score++;
			if (scoreScoreText.score > 15)
			{
				Rotator.speed = -Rotator.speed;
			}
			isPinned = true;
        }
        else if (collision.CompareTag("Pin") )
        {
            SaveScore(scoreScoreText.score);
            FindObjectOfType<GameManager>().EndGame();
        }
	}
	void SaveScore(int score)
	{
		if (LoadScore() < score)
		{
			PlayerPrefs.SetInt("HighScore", score);
			PlayerPrefs.Save();
		}
		
	}
	int LoadScore()
	{
		return PlayerPrefs.GetInt("HighScore", 0);
	}
}
