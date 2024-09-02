using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Enemy Movement/Diagonal")]
public class DiagonalMove : FreeMove
{
    public override int Intervals { get => 8; }
    public virtual int IntervalSize { get => 45; }
    
    public override float MakeAngle(){
        return base.MakeAngle()*IntervalSize;
    }
}
