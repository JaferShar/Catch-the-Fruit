using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    
    public Text scoreText;
    public Text comboText;

    public static int maxScore = 0;
    public static int maxCombo = 0;
    private int score = 0;
    private int combo = 0;

    
    private readonly int bigCollPoints = 30;
    private readonly int collPoints = 5;

    void Start()
    {
        comboText.text = "";
        scoreText.text = 0.ToString();
        maxScore = 0;
        maxCombo = 0;
    }

    public void PickupBigColl() 
    {
        score += bigCollPoints * (combo + 1);
        scoreText.text = score.ToString();
        AddCombo();
    }

    public void PickupColl() 
    {
        score += collPoints * (combo + 1);
        if (score > maxScore) 
        {
            maxScore = score;
        }
        scoreText.text = score.ToString();
        AddCombo();
    }

    private void AddCombo() 
    {
        combo++;
        if (combo > maxCombo) 
        {
            maxCombo = combo;
        }
        comboText.text = "x" + combo.ToString();
    }

    public void ResetCombo() 
    {
        combo = 0;
        comboText.text = "";
    }

    public int GetCombo() 
    {
        return combo;
    }

}
