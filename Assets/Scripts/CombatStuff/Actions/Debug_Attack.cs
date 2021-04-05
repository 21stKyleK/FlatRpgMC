using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Debug_Attack : MonoBehaviour
{
    public IgnoreStatus yarg ;
    public void DoThing()
    {
        yarg.DoAction(gameObject ,1);
    }
}
