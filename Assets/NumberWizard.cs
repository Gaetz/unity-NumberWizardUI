﻿using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour
{
    public Text text;

    int max;
    int min;
    int guess;
    int maxGuessesAllowed;

    // Use this for initialization
    void Start()
    {
        ResetGame();
    }

    void ResetGame()
    {
        max = 1000;
        min = 1;
        guess = 500;
        maxGuessesAllowed = 12;
        // Display
        text.text = guess.ToString();
    }

    public void GuessHigher()
    {
        min = guess + 1;
        Guess();
    }

    public void GuessLower()
    {
        max = guess - 1;
        Guess();
    }

    void Guess()
    {
        guess = Random.Range(min, max + 1);
        text.text = guess.ToString();
        maxGuessesAllowed = maxGuessesAllowed - 1;
        if(maxGuessesAllowed == 0)
            SceneManager.LoadScene("Victory");
    }
}