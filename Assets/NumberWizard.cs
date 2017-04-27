using UnityEngine;
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
        // Allow to reach max number
        max = max + 1;
        // Display
        text.text = guess.ToString();
    }

    public void GuessHigher()
    {
        min = guess;
        Guess();
    }

    public void GuessLower()
    {
        max = guess;
        Guess();
    }

    void Guess()
    {
        guess = (max + min) / 2;
        text.text = guess.ToString();
        maxGuessesAllowed = maxGuessesAllowed - 1;
        if(maxGuessesAllowed == 0)
            SceneManager.LoadScene("Victory");
    }
}