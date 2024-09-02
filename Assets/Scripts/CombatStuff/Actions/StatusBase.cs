using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class StatusBase : MonoBehaviour
{
    public byte Type;
    public int Turns;

    //public static Image notif;
    //might possibly use an SO list to pull from

    //public Paralysis(int t)
    //{

    //}

    //or Start
    //public void Make()
    //{

    //    //create icon
    //}

    public virtual void Action()
    {
        Turns--;
        if(Turns <= 0)
        {
            End();
        }
    }

    public virtual void End()
    {
        //Destroy thing
        Destroy(this);
    }

    public virtual void Already(int t)
    {
        Turns += t;
    }

    public override bool Equals(object other)
    {
        return Type == ((StatusBase) other).Type;
    }

}
