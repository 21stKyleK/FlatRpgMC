using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Modified")]
public class StrengthMod : BasicAction
{
    //can be used as certain status effects

    //how much stronger the supplied damage will be
    public float Application;

    public override void AttackTarget(GameObject tar, int dmg)
    {
        base.AttackTarget(tar, (int) (dmg*Application) );
    }
}
