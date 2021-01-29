using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseEnemyMove : ScriptableObject
{
    //otherwise known as None/Still
    public abstract Vector2 Move(float spd){
        return new Vector2(0 , 0);
    }

    public abstract float MakeAngle();
}
