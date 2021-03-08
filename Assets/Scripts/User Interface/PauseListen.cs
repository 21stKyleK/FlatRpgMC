using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PauseListen : BackMenu
{
    public UnityEvent ClickBruh;

    private void Update()
    {
        if (!notPos && Input.GetAxisRaw("Fire1") > 0)
        {
            ChangeTime();

            //Debug.Log(Time.timeScale);
            //notPos.SetValue(false);

            PauseOn.Invoke();
        }

        if(Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1) || Input.GetMouseButtonDown(2))
        {
            ClickBruh.Invoke();
        }
    }

    private void OnDestroy()
    {
        notPos.SetValue(false);
    }
}
