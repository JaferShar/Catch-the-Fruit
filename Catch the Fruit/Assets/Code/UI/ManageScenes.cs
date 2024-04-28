using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManageScenes : MonoBehaviour
{
    private static List<int> levels = new() {1, 2, 3, 4};
    public void PressPlay() {
        int randomNumber = Random.Range(0, levels.Count - 1);
        int randomLevel = levels[randomNumber];
        levels.Remove(randomNumber);
        SceneManager.LoadSceneAsync(randomLevel);
    }
}
