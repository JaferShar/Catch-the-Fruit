using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    
    public Text scoreText;
    public Text comboText;

    private int score = 0;
    private int combo = 0;
    private readonly int bigCollPoints = 30;
    private readonly int collPoints = 5;

    void Start()
    {
        comboText.text = "";
        scoreText.text = 0.ToString();
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
        scoreText.text = score.ToString();
        AddCombo();
    }

    private void AddCombo() 
    {
        combo++;
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
