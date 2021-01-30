using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[CreateAssetMenu(menuName = "Enemy Movement/None")]
public abstract class BaseEnemyMove : ScriptableObject
{
    //otherwise known as None/Still
    public Vector2 Move(float spd);

    public float MakeAngle();

    //The modifier 'virtual' is not valid for this item
}
