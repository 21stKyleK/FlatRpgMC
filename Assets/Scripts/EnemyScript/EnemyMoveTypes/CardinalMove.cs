using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Enemy Movement/Cardinal")]
public class CardinalMove : DiagonalMove
{
    public override int Intervals { get => 4; }
    public override int IntervalSize{ get => 90; }
}
