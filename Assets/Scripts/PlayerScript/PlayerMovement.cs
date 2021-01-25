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
    public Axis x = new Axis("Horizontal");
    public Axis y = new Axis("Vertical");
    //public Axis b = new Axis(whatever the shift is);
    //run speed (if the build doesn't remove the problem, then I don't kow what will)

    public Rigidbody2D rb;
    //can't initialize and grab a componetn
    //but the Inspector let's you put the rigid body in

    //private void Start()
    //{
        
    //}

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(x * mSpd * Time.deltaTime, y * mSpd * Time.deltaTime);
    }
}
