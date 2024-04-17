using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PressRetry : MonoBehaviour
{
    public void RetryGame()
    {
        SceneManager.LoadSceneAsync(1);
    }
}
