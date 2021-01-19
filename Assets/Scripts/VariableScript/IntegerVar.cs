using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu (menuName = "Scriptable Variables/Integer")]
public class IntegerVar : ScriptableObject
{
    public int Value;

    public void SetValue(int v)
    {
        Value = v;
    }

    public void SetValue(IntegerVar v)
    {
        Value = v.Value;
    }

    public void AddValue(int v)
    {
        Value += v;
    }
    public void AddValue(IntegerVar v)
    {
        Value += v.Value;
    }
}
