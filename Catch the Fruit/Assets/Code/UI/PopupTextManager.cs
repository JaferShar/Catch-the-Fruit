using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using DG.Tweening;
using Unity.VisualScripting;

public class PopupTextManager : MonoBehaviour
{

    public static PopupTextManager instance;
    public GameObject popupTextPrefab;
    public float DestroyTime;

    private List<GameObject> popupTexts = new List<GameObject>();
    private int poolSize = 5;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
     private void GenerateTextObjects(List<GameObject> popupTexts)
    {
        for (int i = 0; i < poolSize; i++)
        {
            GameObject popupText = Instantiate(popupTextPrefab, Vector3.zero, Quaternion.identity);
            popupText.SetActive(false);
            popupTexts.Add(popupText);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        GenerateTextObjects(popupTexts);
    }
   

    private GameObject GetTextObject(List<GameObject> popupTexts)
    {
        for (int i = 0; i < poolSize; i++)
        {
            if (!popupTexts[i].activeInHierarchy)
            {
                return popupTexts[i];
            }
        }

        return null;
    }

    public void GenerateTextObject(GameObject popupText, Vector3 position)
    {
        if (popupText == null) return;

        popupText.transform.position = position;
        popupText.SetActive(true);
        StartCoroutine(DisablePopupText(popupText));
        popupText.GetComponent<TextMeshPro>().DOFade(0, DestroyTime);
    }

    public void ShowPopupText(Vector3 position)
    {
        GenerateTextObject(GetTextObject(popupTexts), position);
    }

    private IEnumerator DisablePopupText(GameObject popupText)
    {
        yield return new WaitForSeconds(DestroyTime);
        popupText.SetActive(false);
        popupText.GetComponent<TextMeshPro>().alpha = 1;
    }
}
