using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[CreateAssetMenu(menuName = "Attacks/Modified")]
public interface StrengthMod
{
    //can be used as certain status effects

    //how much stronger the supplied damage will be
    float Application { get; set; }

    int CalcDmg(int dmg); //=> dmg;
}
