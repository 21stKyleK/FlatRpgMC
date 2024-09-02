using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFighter : Fighter
{
    public new IntegerVar hp, maxHp;

    public override void TakeDamage(int dmg) {
        hp.AddValue(-dmg);
    }

    public override void CalcDamage(float dmg)
    {
        TakeDamage( (int) dmg);
    }
}
