using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Attacks/Basic")]
public class BasicAction : ScriptableObject
{
    //positive, does damage; negative, heals damage;
    public int Damage;

    public virtual void AttackTarget(GameObject tar)
    {
        tar.GetComponent<Fighter>().CalcDamage(Damage);
    }
}
