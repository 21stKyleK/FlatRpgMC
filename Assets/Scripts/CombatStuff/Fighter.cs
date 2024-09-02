using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class Fighter : MonoBehaviour
{
    // how many hit points until the enemy is defeated
    public int hp, maxHp;

    //status resistances
    public List<int> resist;

    //current ailment list
    public List<StatusBase> ailments;

    //graphics
    public Sprite enemyDude;

    public virtual void TakeDamage(int dmg)
    {
        hp -= dmg;
    }

    public virtual void CalcDamage(float dmg)
    {
        //other damage calulations
        TakeDamage((int) dmg);
    }

    public virtual void ApplyStatus(List<StatusBase> ail)
    {
        //stat changes should be monobehaviours (stat amount changed, able to be created without much hassle)

    }
}
