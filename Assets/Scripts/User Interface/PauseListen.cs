using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PauseListen : MonoBehaviour
{
    public BoolVar notPos;

    public UnityEvent PauseOn;


    private void Update()
    {
        if (!notPos && Input.GetAxisRaw("Fire1") > 0)
        {
            Time.timeScale = Time.timeScale.Equals(0) ? 1 : 0;

            //Debug.Log(Time.timeScale);
            //notPos.SetValue(false);

            PauseOn.Invoke();
        }

        if(Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1) || Input.GetMouseButtonDown(2))
        {

        }
    }

    private void OnDestroy()
    {
        notPos.SetValue(false);
    }
}
