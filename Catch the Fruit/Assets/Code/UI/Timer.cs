using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    private static float timeRemaining = 90f;
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
            SceneManager.LoadScene("FillForm" + SceneManager.GetActiveScene().buildIndex);
            timerText.text = "00:00";
        }
    }

    public static void ResetTimer()
    {
        timeRemaining = 90f;
    }
}
