using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu (menuName = "Scriptable Variables/Layered Image")]
public class ImageSO : ScriptableObject {

    public Color BackColor;
    public Sprite Layer1, Layer2, Layer3;

    public void SetColor(float r, float b, float g)
    {
        BackColor = new Color(r,b,g,1);
    }

    public void SetLayer1(Sprite l1)
    {
        Layer1 = l1;
    }

    public void SetLayer2(Sprite l2)
    {
        Layer2 = l2;
    }

    public void SetLayer3(Sprite l3)
    {
        Layer3 = l3;
    }

    public Sprite GetLayer(int i)
    {
        switch (i)
        {
            case (0):
                return Layer1;
            case (1):
                return Layer2;
            default:
                return Layer3;
        }
    }
}
