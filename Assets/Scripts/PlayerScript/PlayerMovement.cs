using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
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
    public Rigidbody2D rb;
    //can't initialize and grab a componetn

    public void FixedUpdate()
    {
        
    }
}
