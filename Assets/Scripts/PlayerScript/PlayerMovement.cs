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
        rb.velocity = new Vector2(normie.x * mSpd * Time.deltaTime * (1 + b * boostAmt), normie.y * mSpd * Time.deltaTime * (1 + b * boostAmt));
    }
}
