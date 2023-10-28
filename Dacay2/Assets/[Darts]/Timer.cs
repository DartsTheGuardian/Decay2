using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timeValue = 60; // The initial time value in seconds
    public Text timerText; // Assign the UI Text component to display the timer

    void Start()
    {
        // Find and initialize the UI Text component
        timerText = GetComponent<Text>();
    }

    void Update()
    {
        // Update the timer and display it on the screen
        if (timeValue > 0)
        {
            timeValue -= Time.deltaTime;
            DisplayTime(timeValue);
        }
        else
        {
            timerText.text = "Time's up!";
        }

        //Modificator
        if (Input.GetKeyDown(KeyCode.Backspace)){
            timeValue += 1; //1 seconde
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        // Convert the time to minutes and seconds
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        // Update the timer text
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}

