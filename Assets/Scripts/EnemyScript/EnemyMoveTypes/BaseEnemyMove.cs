using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[CreateAssetMenu(menuName = "Enemy Movement/None")]
public abstract class BaseEnemyMove : ScriptableObject
{
    //otherwise known as None/Still
    public abstract Vector2 Move(float spd);

    public abstract float MakeAngle();
}
