using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Run Time Set/LoadingZones")]
public class LoadZoneRTS : ObjectRTS
{
    public override GameObject CheckActive()
    {
        foreach (GameObject arg in Things)
        {
            if (arg.GetComponent<LoadZoneTrigger>().Bruh)
            {
                return arg;
            }
        }
        return base.CheckActive();
    }
}
