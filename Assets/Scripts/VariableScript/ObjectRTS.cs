﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Run Time Set/GameObject")]
public class ObjectRTS : ScriptableObject
{
    public List<GameObject> Things = new List<GameObject>();

    public void Add(GameObject thing)
    {
        if (!Things.Contains(thing))
        {
            Things.Add(thing);
        }
    }

    public void Remove(GameObject thing)
    {
        if (Things.Contains(thing))
        {
            Things.Remove(thing);
        }
    }

    public void ClearOut()
    {
        Things = new List<GameObject>();
    }

    public GameObject GetThing(int i)
    {
        if (i >= 0 && i < Things.Count)
        {
            return Things[i];
        }
        return Things[0];
    }

    public int GetLength()
    {
        return Things.Count;
    }

    public bool CheckThing(GameObject thing)
    {
        return Things.Contains(thing);
    }
}
