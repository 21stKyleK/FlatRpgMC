using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BackMenu : MonoBehaviour
{
    public BoolVar notPos;

    public UnityEvent PauseOn;

    private void Update()
    {
        if(!notPos && Input.GetAxisRaw("Fire3") > 0)
        {
            //Debug.Log("Thing");
            PauseOn.Invoke();
        }
    }

    public void ChangeTime()
    {
        Time.timeScale = Time.timeScale.Equals(0) ? 1 : 0;
    }

    public void FlipEnabled()
    {
        enabled = enabled ? false : true;
    }
}
