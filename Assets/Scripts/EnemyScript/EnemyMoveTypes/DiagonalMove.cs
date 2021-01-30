using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiagonalMove : FreeMove
{
    intervals = 8;
    public int intervalSize;
    
    public override float MakeAngle(){
        return base.MakeAngle()*intervalSize;
    }
}
