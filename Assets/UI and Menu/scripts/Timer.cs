using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Timer : MonoBehaviour
{
    public float timeRemaining = 2;
    public bool timerIsRunning = false;
    public Text timeText;
    public Text EndTime;
    public float totalTime = 0;
    private float timeFactor = 0;
    [SerializeField] public float AddTime = 5f;
    public GameObject EndPage;
    private void Start()
    {
        // Starts the timer automatically
        timerIsRunning = true;

    }
    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                totalTime += Time.deltaTime;
                DisplayTime(timeRemaining);
            }
            else
            {
                Debug.Log("Time has run out!");
                timeRemaining = 0;
                timerIsRunning = false;
                EndPage.SetActive(true);
                TotalTime(totalTime);
            }
        }
    }
    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
    public void IncreaseTime()
    {
        
        timeRemaining = timeRemaining + AddTime;
        timeFactor = totalTime * 5;
        totalTime += AddTime/timeFactor;
        Debug.Log("timeFactor: "+timeFactor);
    }
    public void TotalTime(float timeToDisplay)
    {
        timeToDisplay += 1;
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        EndTime.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
