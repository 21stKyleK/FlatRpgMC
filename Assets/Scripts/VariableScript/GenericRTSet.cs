using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericRTSet<T> : ScriptableObject
{
    public List<T> things = new List<T>();
}
