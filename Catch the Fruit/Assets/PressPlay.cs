using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PressPlay : MonoBehaviour
{
   public void PlayGame()
   {
       SceneManager.LoadSceneAsync(1);
       Debug.Log("Play Game");
   }
}
