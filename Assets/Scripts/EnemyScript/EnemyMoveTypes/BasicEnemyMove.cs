using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicEnemyMove //: MonoBehaviour
{
    //specifically Linear
    public int intervals = 4;
    public int itvAmounts = 90;
        /// intervals;

    public Vector2 Move(float speed)
    {
        //return new Vector2(0, 0);

        Vector3 yeesh = Quaternion.Euler(0, 0, MakeAngle()) * Vector3.up;
        yeesh.Normalize();
        return (Vector2) yeesh * speed * Time.deltaTime;

    }

    public float MakeAngle()
    {
        return (int)(GameManager.Instance.GetRandValueInc() * intervals) * itvAmounts;
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
    
    public float GetRandomInc(){
        return Random.value;
    }
    //might make thing really slow, but maybe not

     */
}
