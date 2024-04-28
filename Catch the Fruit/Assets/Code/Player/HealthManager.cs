using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.SceneManagement;


public class HealthManager : MonoBehaviour
{
    public UnityEngine.UI.Image healthbar;
    public float health = 100f;
    public float damageAmount = 10f;
    public float healAmount = 10f;

    private float currVelocity = 0f;

    // Update is called once per frame
    void Update()
    {
        
        health = Mathf.SmoothDamp(health, -50, ref currVelocity, 10);
        healthbar.fillAmount = health / 100f;
        if (health <= 0)
        {
            SceneManager.LoadSceneAsync("GameOver");
        }
    }

    public void TakeDamage() 
    {
        health -= damageAmount;
        healthbar.fillAmount = health / 100f;
    }

    public void Heal()
    {
        health += healAmount;
        health = Mathf.Clamp(health, 0, 100);
        
        healthbar.fillAmount = health / 100f;
    }
}
