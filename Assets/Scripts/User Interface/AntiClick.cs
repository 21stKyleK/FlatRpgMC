using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AntiClick : MonoBehaviour
{
    public UnityEvent ClickBruh;
    private void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1) || Input.GetMouseButtonDown(2))
        {
            //Debug.Log("I'm here");
            ClickBruh.Invoke();
        }
    }
}
