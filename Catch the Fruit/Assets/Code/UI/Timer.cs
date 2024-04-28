using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    float timeRemaining = 5f;
    // Update is called once per frame
    void Update()
    {
        timeRemaining -= Time.deltaTime;
        int minutes = Mathf.FloorToInt(timeRemaining / 60);
        int seconds = Mathf.FloorToInt(timeRemaining % 60);
        if (timeRemaining > 0)
        {
            timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }
        else
        {
            SceneManager.LoadScene("Home");
            timerText.text = "00:00";
        }
    }
}
