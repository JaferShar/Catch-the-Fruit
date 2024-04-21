using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PressHome : MonoBehaviour
{
    
    public void Home()
    {
        SceneManager.LoadScene(0);
    }
}
