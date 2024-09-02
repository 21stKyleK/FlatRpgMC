using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //[Serializable]
    public class Axis
    {
        public string name;
        public Axis(string n)
        {
            name = n;
        }

        public static implicit operator float (Axis a){
            return Input.GetAxisRaw(a.name);
        }
    }

    public IntegerVar mSpd;
    public FloatVar boostAmt;
    public Axis x = new Axis("Horizontal");
    public Axis y = new Axis("Vertical");
    public Axis b = new Axis("Fire3");
    //run speed (if the build doesn't remove the problem, then I don't kow what will)

    public Rigidbody2D rb;
    //can't initialize and grab a componetn
    //but the Inspector let's you put the rigid body in

    //private void Start()
    //{
        
    //}

    private void FixedUpdate()
    {
        Vector2 normie = new Vector2(x, y).normalized;
        rb.velocity = normie * mSpd * Time.deltaTime * (1 + b * boostAmt);
    }

    //for(int i = 2; i<4; i++){
    //        //should either lead to 1/2 or 1/4 increments, x = new x, new y, x-2 = horizontal, vertical
    //        dArray[i] = Mathf.Clamp(dArray[i] - ((dArray[i - 2] * -0.125f) + Mathf.Clamp(dArray[i] - (dArray[i] * Mathf.Abs(dArray[i - 2]) ), -0.5f, 0.5f ) )  , -1, 1);
    //    }
}
