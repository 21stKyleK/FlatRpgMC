using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public interface DebuffBasic
{
    public int Turns { get; set; }

    public Image Notif { get; set; }

    public void Made();
    //creates an icon when started


}
