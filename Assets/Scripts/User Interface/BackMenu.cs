using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BackMenu : MonoBehaviour
{
    public BoolVar notPos;

    public UnityEvent PauseOn;

    private void FixedUpdate()
    {
        if(!notPos && Input.GetAxisRaw("Fire1") > 0)
        {

        }
    }
}
