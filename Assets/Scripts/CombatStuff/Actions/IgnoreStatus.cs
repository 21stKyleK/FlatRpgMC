using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Piercing")]
public class IgnoreStatus : BasicAction
{
    public override void AttackTarget(GameObject tar, int dmg)
    {
        tar.GetComponent<Fighter>().TakeDamage(dmg);
    }
}
