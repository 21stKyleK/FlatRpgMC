using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatistics : MonoBehaviour
{
    //x and y spawn positions for loading zones
    //public double xSpPos, ySpPos;
    public int hp, hpMax, act, actMax, spd;
    //public byte lvl;

    //static PlayerDataStuff thing;

    //void Start()
    //{
    //    CeaseDestroy();
    //}

    //public void CeaseDestroy()
    //{
    //    if (thing == null)
    //    {
    //        thing = this;
    //        DontDestroyOnLoad(this.gameObject);
    //        //this is supposed to see if a method called SceneChanged from source video source file was called, for components attached to this object
    //        //UnityEngine.SceneManagement.SceneManager.activeSceneChanged += SceneChanged;
    //    }
    //    else
    //    {
    //        Destroy(this.gameObject);
    //    }
    //}
}
