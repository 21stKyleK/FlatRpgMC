using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Enemy Movement/Free")]
public class FreeMove : NoMove
{
    public int intervals = 360;
    
    public override Vector2 Move(float speed)
    {
        //return new Vector2(0, 0);

        Vector3 yeesh = Quaternion.Euler(0, 0, MakeAngle()) * Vector3.up;
        
        return (Vector2)yeesh.normalized * speed * Time.deltaTime;

    }

    public override float MakeAngle()
    {
        return (int)(Random.value * intervals);
    }
    /*
     * get abgle intervals
     * 
     * private float AngleChange(float a){
     *  return a * interval;
     * }
     * 
     * do special thing (turn enemy invisible) actually, that might be better suited for the enemy script iself, or a different thing altogether
     * 
     * get random value (either from here or else where)
    
    public float GetRandomInc(){
        return Random.value;
    }
    //might make thing really slow, but maybe not

     */
}
