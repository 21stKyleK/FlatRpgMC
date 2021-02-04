using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneSetup : MonoBehaviour
{
    public FloatVar camX, camY;
    public float x, y;

    private void Awake()
    {
        camX.SetValue(x);
        camY.SetValue(y);
    }
}
