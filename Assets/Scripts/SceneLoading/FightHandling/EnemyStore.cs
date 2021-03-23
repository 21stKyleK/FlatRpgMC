using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStore : MonoBehaviour
{
    public GameObjectVar enemy;

    public bool defeated;
    //public GameObject enemy;

    //public void SetEnemy(GameObject en)
    //{
    //    enemy = en;
    //}

    public void SetStyle(bool kill)
    {
        defeated = kill;
    }

    public void HandleEnemy()
    {
        //if (defeated) { Destroy(enemy.Value); }

        //put destruction in enemy's script
        enemy.Value.GetComponent<FightBouncer>().PostFightBreak(!defeated);

        //enemy.SetValue(new GameObject());
    }
}
