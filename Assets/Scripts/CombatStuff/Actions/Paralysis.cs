using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Paralysis : MonoBehaviour
{
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
}
