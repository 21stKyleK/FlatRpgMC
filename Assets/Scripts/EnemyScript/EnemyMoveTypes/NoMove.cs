using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Enemy Movement/None")]
public class NoMove : ScriptableObject
{
    public virtual Vector2 Move(float spd, float angle) { return new Vector2(0, 0); }

    public virtual float MakeAngle() { return 0; }
}
