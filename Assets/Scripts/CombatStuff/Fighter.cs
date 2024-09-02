using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fighter : MonoBehaviour
{
    // how many hit points until the enemy is defeated
    public int hp, maxHp;

    //immunities

    public void TakeDamage(int dmg)
    {
        hp -= dmg;
    }

    public void CalcDamage(int dmg)
    {
        //other damage calulations
        TakeDamage(dmg);
    }
}
