using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BasicEnemyMove //: MonoBehaviour
{
    public Vector2 Move(float speed, float angle)
    {
        return new Vector2(0, 0);
        /*
         * vector3 yeesh = Quaternian.Euler(0,0, angle) * Vector3.up;
         * yeesh.normalize
         */
    }

    /*
     * get abgle intervals
     * 
     * private float AngleChange(float a){
     *  return a * interval;
     * }
     * 
     * do special thing (turn enemy invisible)
     * 
     * get random value (either from here or else where)
     * 
     */
}
