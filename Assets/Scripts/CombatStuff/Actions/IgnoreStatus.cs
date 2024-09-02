using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Attacks/Piercing")]
public class IgnoreStatus : ScriptableObject
{
    //1 = no change in damage
    public float Application;

    //list of statuses, don't need several interfaces, just leave in default values
    public List<StatusBase> ailments;

    //bool heals;
    //if true, removes statuses

    public virtual void AttackTarget(GameObject tar, int dmg) =>
    //{
        //Debug.Log("under");
        //in case smaller numbers are hard to come by
        //tar.GetComponent<Fighter>().TakeDamage((int)Mathf.Clamp(dmg * Application, 1, float.MaxValue));

        tar.GetComponent<Fighter>().TakeDamage((int)CalcDamage(dmg));
    //}

    public float CalcDamage(int dmg) => dmg * Application;

    public void AffectTarget(GameObject tar) => tar.GetComponent<Fighter>().ApplyStatus(ailments);

    public void DoAction(GameObject tar, int dmg)
    {
        AttackTarget(tar, dmg);

        //Apply statuses
    }
}
