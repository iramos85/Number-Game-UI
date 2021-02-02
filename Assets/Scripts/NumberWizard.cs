using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] int maxGuess;
    [SerializeField] int minGuess;
    [SerializeField] TextMeshProUGUI guessText;

    int guess;

    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        //guess = (maxGuess + minGuess) / 2;
        NextGuess();
    }
    public void OnPressHigher()
    {
        minGuess = guess + 1;
        NextGuess();
    }

    public void OnPressLower()
    {
        maxGuess = guess - 1;
        NextGuess();
    }

    void NextGuess()
    {
        guess = Random.Range(minGuess, maxGuess);
        guessText.text = guess.ToString();
    }
}
