using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class IHealthManager : MonoBehaviour
{
    public abstract void TakeDamage();
    public abstract void Heal();
}
