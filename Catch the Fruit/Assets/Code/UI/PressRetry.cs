using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PressRetry : MonoBehaviour
{
    public static int retries = 1;
    public void RetryGame()
    {
        if (retries > 0) {
            retries--;
            SceneManager.LoadScene(1);
        } else {
            Debug.Log("No more retries");
            SceneManager.LoadScene(0);
        }
        
    }
}
