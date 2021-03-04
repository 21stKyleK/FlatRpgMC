using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetColor : MonoBehaviour
{
    public RawImage yeah;
    public ImageSO bg;

    public void DoThing()
    {
        yeah.color = bg.BackColor;
    }
}
