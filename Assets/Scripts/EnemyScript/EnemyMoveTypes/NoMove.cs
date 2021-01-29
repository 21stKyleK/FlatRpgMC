using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Enemy Movement/None")]
public class NoMove : BaseEnemyMove
{
    public override Vector2 Move(float spd)
    {
        return new Vector2(0, 0);
    }

    public override float MakeAngle()
    {
        return 0;
    }

}
