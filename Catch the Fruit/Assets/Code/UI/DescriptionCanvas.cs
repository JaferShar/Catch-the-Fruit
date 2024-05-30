using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DescriptionCanvas : MonoBehaviour
{

    [SerializeField] private Canvas gameCanvas;
    [SerializeField] private Canvas descriptionCanvas;
    // Start is called before the first frame update
    void Awake()
    {
        gameCanvas.enabled = false;
        Time.timeScale = 0;
    }

    public void CloseDescription()
    {
        gameCanvas.enabled = true;
        descriptionCanvas.enabled = false;
        Time.timeScale = 1;
    }
}
