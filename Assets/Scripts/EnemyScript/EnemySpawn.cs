using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public List<GameObject> enL = new List<GameObject>();
    public float[] rngs;

    //spawn the enemies as soon as possible
    void Awake()
    {
        float bruh = Random.value * 100;

        Instanti
    }

    public GameObject GetEnemy(float x)
    {

    }

    /*
    private GameObject GetEnemy(float x)
    {
        //increases after every unsuccessful return
        float cnt = 0f;

        for (int i = 0; i < spnRt.Length; i++)
        {
            //less than or equal, as x = 100, [n] = 100, then x < [n] wouldn't fire and would go to null which is bad
            //actually, possible for number to return zero, should use +1 for one hundred percent chances
            if (x < spnRt[i] + cnt)
            {
                //returns enemy, like this because they should be the exact same length
                ind = i;
                return GameObject.Find("SceneStarter").GetComponent<StartScene>().en[i];
            }
            cnt += spnRt[i];
        }

        ind = 0;
        //throwaway, as you can't instantiate a null object
        return null;
    }
    */
}
