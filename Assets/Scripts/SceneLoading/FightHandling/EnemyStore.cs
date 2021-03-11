using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStore : MonoBehaviour
{
    public GameObjectVar enemy;
    //public GameObject enemy;

    //public void SetEnemy(GameObject en)
    //{
    //    enemy = en;
    //}

    public void DestroyEnemy()
    {
        Destroy(enemy.Value);

        //put destruction in enemy's script

        enemy = null;
    }
}
