using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManageScenes : MonoBehaviour
{
    private static List<int> levels = new() {1, 2, 3, 4};
    public void PressPlay() {
        if (levels.Count == 0) {
            SceneManager.LoadScene("ThankYou");
        } else {    
            Timer.ResetTimer();
            int randomNumber = Random.Range(0, levels.Count);
            int randomLevel = levels[randomNumber];
            levels.Remove(randomLevel);
            SceneManager.LoadSceneAsync(randomLevel);
        }
    }
}
