using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class MenuAnim : MonoBehaviour
{
    public BoolVar cantDo;

    public UnityEvent ButtonPress;

    public void Handle()
    {
        //Debug.Log("Trigger");
        if (!cantDo) { ButtonPress.Invoke(); }
    }
}
