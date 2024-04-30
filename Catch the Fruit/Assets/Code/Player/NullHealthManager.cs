using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NullHealthManager : IHealthManager
{
    public override void TakeDamage(){}

    public override void Heal(){}
}

