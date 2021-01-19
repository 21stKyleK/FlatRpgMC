using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu (menuName = "Scriptable Variable/Float")]
public class FloatVar : ScriptableObject
{
    public float Value;

    public void SetValue(float v)
    {
        Value = v;
    }

    public void SetValue(FloatVar v)
    {
        Value = v.Value;
    }

    public void AddValue(float v)
    {
        Value += v;
    }
    public void AddValue(FloatVar v)
    {
        Value += v.Value;
    }
}
