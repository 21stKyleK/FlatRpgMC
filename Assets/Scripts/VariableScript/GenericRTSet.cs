using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericRTSet<T> : ScriptableObject
{
    public List<T> Things = new List<T>();
    
    public void Add(T thing){
        if(!Things.Contains(thing)){
            Things.Add(thing);
        }
    }
    
    public void Remove(T thing){
        if(Things.Contains(thing)){
            Things.Remove(thing);
        }
    }

    public void ClearOut()
    {
        Things = new List<T>();
    }

    public T GetThing(int i)
    {
        if(i >= 0 && i < Things.Count)
        {
            return Things[i];
        }
        return Things[0];
    }
    
    /* in an extension for LoadingZones
    include a method to reset the List
    and a method that goes through the List to find an object with a !null collider
    */
}
