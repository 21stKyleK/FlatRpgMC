using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawn : MonoBehaviour
{
    public FloatVar xSpwn, ySpwn;

    public void SetPosition()
    {
        transform.position = new Vector2(xSpwn, ySpwn);
    }

    //put in other spawning stuff that may be required
}
