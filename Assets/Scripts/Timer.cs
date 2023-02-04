using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEditor;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    //Variables
    private bool TimerState = true;
    private float currentTime;
    public int startingTime;
    public Text currentTimeText;
    
    // Start is called before the first frame update
    
    void Start()
    {
        //3 minutes
        startingTime = 3;
        //time in seconds
        currentTime = startingTime * 60;
    }

    // Update is called once per frame
    void Update()
    {
        //If the timer is on, start it
        if(TimerState == true)
        {
            currentTime = currentTime - Time.deltaTime;
        }
        if(currentTime <= 0)
        {
            SceneManager.LoadScene("LoseScene");
        }

        TimeSpan time = TimeSpan.FromSeconds(currentTime);
        //displaying the text
        currentTimeText.text = time.Minutes.ToString() + ":" +time.Seconds.ToString();
    }
    //Recording the time you beat the game with the scene changing functionality
}

