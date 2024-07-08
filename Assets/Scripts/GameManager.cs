using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;


public class GameManager : MonoBehaviour
{
    private bool GameEnded = false;
    public GameObject again;
    public Canvas startCanvas;
    public Rotator Rotator;
    public PinSpawner PinSpawner;
    public Pin pin;
    public Animator Animator;
    public SpriteRenderer back;


	public void EndGame()
    {
        if (GameEnded)
        {
            return;
        }
        else
        {
			Debug.Log("aaaaaaaaaa");
			GameEnded = true;
            Rotator.enabled = false;
            PinSpawner.enabled = false;
            back.color = new Color(1f,0f,46f/255,1f);
            Animator.SetTrigger("EndGame");
            again.SetActive(true);

        }
    }
    public void StartGame()
    {
		Rotator.enabled = true;
		PinSpawner.enabled = true;
        startCanvas.enabled = false;
	}
    public void PlayAgain()
    {
        SceneManager.LoadScene(2);
    }

	
	
}
