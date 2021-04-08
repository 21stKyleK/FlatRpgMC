using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetCohorts : MonoBehaviour
{
    public ObjectRTS enemies;

    public int i = 0;

    public void SetEnemies(List<GameObject> l)
    {
        enemies.Set(l);
        i = 0;

        //CreateEnemies();
    }

    public void CreateEnemies()
    {
        GameObject bruh = Instantiate(enemies.GetThing(i));

        bruh.GetComponent<RectTransform>().anchoredPosition = new Vector2(713.5f, 712.5f);

        //use foreach in final
    }

    public Fighter GetCurrent()
    {
        return enemies.GetThing(i).GetComponent<Fighter>();
    }

    public void Remove()
    {
        GameObject des = enemies.GetThing(i);

        enemies.Remove(des);

        Destroy(des);
    }

    public void RemoveAll()
    {
        i = 0;

        while (enemies.GetLength() > 0)
        {
            GameObject des = enemies.GetThing(i);

            enemies.Remove(des);

            Destroy(des);
        }
    }
}
