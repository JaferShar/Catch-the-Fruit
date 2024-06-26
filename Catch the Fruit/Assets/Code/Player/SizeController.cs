using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeController : MonoBehaviour
{

    public float scaleSize = 1.0f;
    public Transform playerImage;
    public BoxCollider2D playerCol;
    public ScoreManager scoreManager;

    private int multipleOf = 1;


    // Update is called once per frame
    void Update()
    {
        if (scoreManager.GetCombo() == 10 * multipleOf && scoreManager.GetCombo() <= 30) {
            scaleSize -= 0.2f;
            multipleOf++;
            playerImage.transform.localScale = new Vector3(scaleSize, 1, 1);
        }

        if (scoreManager.GetCombo() == 0) {
            scaleSize = 1.0f;
            multipleOf = 1;
            playerImage.transform.localScale = new Vector3(1, 1, 1);
        }
        
    }
}
