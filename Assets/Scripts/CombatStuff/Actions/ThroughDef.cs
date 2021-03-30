using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Attacks/Basic")]
public class ThroughDef : IgnoreStatus
{
    //positive, does damage; negative, heals damage;
    //public int Damage;

    public override void AttackTarget(GameObject tar, int dmg)
    {
        tar.GetComponent<Fighter>().CalcDamage(dmg);
    }
}
