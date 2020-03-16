using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    // Start is called before the first frame update
    int max, min, guess;
    
    void Start()
    {
        ResetGame();
        StartGame();
    }

    void StartGame()
    {
        Debug.Log("Welcome to Number Wizard");
        Debug.Log("Pick a Number");
        Debug.Log("Highest Number : " + max);
        Debug.Log("Lowest Number : " + min);
        Debug.Log("Tell me if your guess is higher or lower than+ " + guess);
        Debug.Log("Push up for higher, Push down for lower, Press enter for correct");
        max = max + 1;
    }

    void ResetGame()
    {
        max = 1000;
        min = 1;
        guess = 500;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            NextGuess();

        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();
        }

        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("There you go!");
            Start();
        }

    }

    void NextGuess()
    {
        guess = (max + min) / 2;
        Debug.Log("Is your guess: " + guess);
    }

}
