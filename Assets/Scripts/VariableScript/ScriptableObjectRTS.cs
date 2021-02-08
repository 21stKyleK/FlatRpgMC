using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Run Time Set/EnemyMovements")]
public class ScriptableObjectRTS : ScriptableObject
{
    public List<ScriptableObject> dudes = new List<ScriptableObject>();

    public ScriptableObject GetThing(int i)
    {
        if(i >= 0 && i < dudes.Count)
        {
            return dudes[i];
        }

        return dudes[0];
    }
    /*
     * figure out how to find the index of Assets
    public int GetIndex()
    {

        return 0;
    }*/
}
