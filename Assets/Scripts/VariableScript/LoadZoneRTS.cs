using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Run Time Set/LoadingZones")]
public class LoadZoneRTS : ObjectRTS
{
    public GameObject GetActive()
    {
        foreach (GameObject arg in Things)
        {
            if (arg.GetComponent<LoadZoneTrigger>().Bruh)
            {
                return arg;
            }
        }
        return new GameObject();
    }
}
