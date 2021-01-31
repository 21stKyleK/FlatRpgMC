using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagment;
using UnityEngine.Event;

public class StartScene : MonoBehaviour
{
    public ObjectRTS loadZones;
    public Scene current;
    public UnityEvent StartFadeOut;
    
    public FloatVar pX, pY;
    //player x and y positions
    //have Camera's constraints in SOs

    //// Start is called before the first frame update
    //void Start()
    //{
    //    GameObject.FindGameObjectWithTag("MainCamera").GetComponent<PlayerCamera>().SetConstraints(x, y);
    //    //Destroy(this);
    //}

    public void NewSceneLoad(){
        LoadZoneTrigger bruh = loadZone.GetActivated().GetComponent;
        SceneManager.UnloadSceneAsync(current);
        current = bruh.scene;
        float x = bruh.x, y = bruh.y;
        pX.SetValue(x);
        pY.SetValue(y);
        SceneManager.LoadSceneAsync(current);
        StartFadeOut.Invoke();
    }
    //may need different systems to compensate for fight screens
    //also, enemies in fight screens will be put into canvas objects
     
}
