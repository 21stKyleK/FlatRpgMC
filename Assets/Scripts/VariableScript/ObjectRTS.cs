using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Run Time Set/GameObject")]
public class ObjectRTS : GenericRTSet<GameObject>
{
    public void ClearOut(){
        Things = new List<GameObject>();
    }
    
    public virtual GameObject CheckActive(){
        //foreach(GameObject arg in Things){
        //    if(arg.activeSelf){
        //        return arg;
        //    }
        //}
        return Things[0];
    }
}
