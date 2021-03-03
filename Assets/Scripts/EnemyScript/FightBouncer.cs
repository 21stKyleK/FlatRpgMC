using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
//using UnityEngine.UI;

public class FightBouncer : MonoBehaviour
{
    public UnityEvent Encountered;

    public Texture bg;

    private void OnCollisionEnter2D(Collision2D col)
    {
        //Time.timeScale = 0;

        Encountered.Invoke();
    }
}
