using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PauseListen : BackMenu
{
    private void Update()
    {
        if (!notPos && Input.GetAxisRaw("Fire1") > 0)
        {
            ChangeTime();

            //Debug.Log(Time.timeScale);
            //notPos.SetValue(false);

            PauseOn.Invoke();
        }
    }

    private void OnDestroy()
    {
        notPos.SetValue(false);
    }
}
