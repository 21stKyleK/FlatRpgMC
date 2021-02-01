using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[CreateAssetMenu(menuName = "Enemy Movement/None")]
public abstract class BaseEnemyMove : ScriptableObject
{
    //otherwise known as None/Still
    //actually, can't instantiate abstract base
    public virtual Vector2 Move(float spd, float angle) { return new Vector2(0, 0); }

    public virtual float MakeAngle() { return 0; }

    //The modifier 'virtual' is not valid for this item
}
