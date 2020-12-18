using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnBattleTactics : MonoBehaviour
{
    public int hp, spd;
    public Texture battleGround;

    //should instead be set by the SceneStart/EnemyHome

    // Start is called before the first frame update
    void Start()
    {
        battleGround = transform.parent.GetComponent<HomeData>().GetImage();

        //Debug.Log(GetTexture());
    }

    // Update is called once per frame
    public Texture GetTexture()
    {
        return battleGround;
    }


}
