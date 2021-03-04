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
        //Time.timeScale = 0;

        bg.SetColor(bgc);

        bg.SetLayer1(l1);
        bg.SetLayer2(l2);
        bg.SetLayer3(l3);

        Encountered.Invoke();
    }
}
