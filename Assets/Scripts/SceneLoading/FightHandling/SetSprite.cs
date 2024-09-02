using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetSprite : MonoBehaviour
{
    public Image yeah;
    public ImageSO bg;

    public void DoThing(int i)
    {
        yeah.sprite = bg.GetLayer(i);
    }
}
