using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI maxScoreText;
    [SerializeField] TextMeshProUGUI maxComboText;

    public void Start()
    {
        maxScoreText.text = ScoreManager.maxScore.ToString();
        maxComboText.text = ScoreManager.maxCombo.ToString();
    }
}
