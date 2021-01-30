using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRTS : GenericRTSet<LoadingZoneTest>
{
    public void ClearOut(){
        things = new List<LoadingZoneTest>();
    }
    
    public LoadingZoneTest CheckActive(){
        foreach(LoadingZoneTest arg in things){
            if(arg.Bruh){
                return arg;
            }
        }
        return things.Get(0);
    }
}
