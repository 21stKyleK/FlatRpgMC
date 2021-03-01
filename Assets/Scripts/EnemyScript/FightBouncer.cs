using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FightBouncer : MonoBehaviour
{
    public UnityEvent StartFight;

    private void OnCollisionEnter2D(Collision2D col)
    {
        Time.timeScale = 0;

        StartFight.Invoke();
    }
}
