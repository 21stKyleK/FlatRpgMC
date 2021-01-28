using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseEnemyMove : ScriptableObject
{
    public abstract Vector2 Move(float spd);

    public abstract float MakeAngle();
}
