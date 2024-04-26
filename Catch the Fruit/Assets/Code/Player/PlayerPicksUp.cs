using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerPicksUp : MonoBehaviour
{
    public HealthManager healthManager;
    public ScoreManager scoreManager;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.gameObject.tag)
        {
            case "DamageCollectible":
                scoreManager.ResetCombo();
                healthManager.TakeDamage();
                break;
                //old value = "Collectible"
            case "Collectible":
                scoreManager.PickupColl();
                healthManager.Heal();
                break;
            case "BigCollectible":
                scoreManager.PickupBigColl();
                healthManager.Heal();
                break;
            default:
                break;
        }
    }
}
