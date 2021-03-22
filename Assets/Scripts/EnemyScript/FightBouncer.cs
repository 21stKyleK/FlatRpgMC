using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
//using UnityEngine.UI;

public class FightBouncer : MonoBehaviour
{
    public UnityEvent Encountered;

    public ImageSO bg;

    public Color bgc;

    public Sprite l1, l2, l3;

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (enabled) {
            //Time.timeScale = 0;

            bg.SetColor(bgc);

            bg.SetLayer1(l1);
            bg.SetLayer2(l2);
            bg.SetLayer3(l3);

            Encountered.Invoke();

            //disabling this script will prevent future run-ins until turned on

            enabled = false;
        }
    }

    //entrance from event to handle the enemy after a fight is over
    public void PostFightBreak(bool peace)
    {
        StartCoroutine(Afterwards(peace));
    }

    //if not peace, then destroy object, else enabled = true;
    public IEnumerator Afterwards(bool peace)
    {
        yield return new WaitForSeconds(0.5f);

        if (peace)
        {
            enabled = peace;
        }
        else
        {
            Destroy(this);
        }
    }
}
