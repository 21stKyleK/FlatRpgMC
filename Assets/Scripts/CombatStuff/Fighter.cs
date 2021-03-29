using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fighter : MonoBehaviour
{
    // how many hit points until the enemy is defeated
    public int hp, maxHp;

    //status resistances

    //current ailment list

    //graphics
    Image thing;

    public virtual void TakeDamage(int dmg)
    {
        hp -= dmg;
    }

    public virtual void CalcDamage(int dmg)
    {
        //other damage calulations
        TakeDamage(dmg);
    }

    public virtual void ApplyStatus()
    {
        //stat changes should be monobehaviours (stat amount changed, able to be created without much hassle)
    }
}
