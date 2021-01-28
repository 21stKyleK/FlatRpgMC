using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.Events;

//[CreateAssetMenu]
public class GameEventEar : MonoBehaviour
{
    //what to register with
    public GameEventHolder papi;

    public UnityEvent theThing;

    private void OnEnable()
    {
        papi.Register(this);
    }

    private void OnDisable()
    {
        papi.Unregister(this);
    }

    public void OnEventRaised()
    {
        theThing.Invoke();
    }
}
