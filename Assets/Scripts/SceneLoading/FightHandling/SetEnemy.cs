using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetEnemy : MonoBehaviour
{
    public GameObjectVar bruh;

    public void DoThing()
    {
        bruh.SetValue(gameObject);
    }
}
