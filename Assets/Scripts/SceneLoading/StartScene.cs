using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class StartScene : MonoBehaviour
{
    public LoadZoneRTS loadZone;
    public string current;
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

    public void SetCurrentScene(string c)
    {
        current = c;
    }

    public void NewSceneLoad(){
        LoadZoneTrigger bruh = loadZone.CheckActive().GetComponent<LoadZoneTrigger>();
        float x = bruh.xTarPos, y = bruh.yTarPos;
        string temp = bruh.scene;
        loadZone.ClearOut();

        SceneManager.UnloadSceneAsync(current);

        SetCurrentScene(temp);

        pX.SetValue(x);
        pY.SetValue(y);

        //Debug.Log(SceneManager.GetActiveScene().name);

        SceneManager.LoadSceneAsync(current, LoadSceneMode.Additive);

        StartFadeOut.Invoke();
    }
    //may need different systems to compensate for fight screens
    //also, enemies in fight screens will be put into canvas objects

    private void OnDestroy()
    {
        loadZone.ClearOut();
    }
}
