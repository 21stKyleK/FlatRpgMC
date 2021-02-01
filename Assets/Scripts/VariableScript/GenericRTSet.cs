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
    
    /* in an extension for LoadingZones
    include a method to reset the List
    and a method that goes through the List to find an object with a !null collider
    */
}
