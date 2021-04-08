using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetCohorts : MonoBehaviour
{
    public List<GameObject> enemies;

    public int i = 0;

    public void SetEnemies(List<GameObject> l)
    {
        enemies = l;
        i = 0;
    }

    public void Remove()
    {
        GameObject des = enemies[i];

        enemies.RemoveAt(i);

        Destroy(des);
    }
}
