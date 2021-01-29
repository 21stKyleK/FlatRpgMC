using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class LoadZoneTrigger : MonoBehaviour
{
    public string scene;
    //the scene to load after touching loading zone
    public float xTarPos, yTarPos;
    //position of spawnpoint. based on loading zone
    public byte tarDir;
    // direction player will face
    //public LoadZoneRTS lad
    //adds the LoadingZones to the list
    public UnityEvent FadeInStart;
    //the thing to start the whole skishkabang, will trigger the camera to do start the FadeIn
    public boolean Bruh{get; set;} = false;
    //whether or not the object was triggered

    private void Start(){
        //lad.Add(this);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        //collision.GetComponent<PlayerMovement>().Activity = false;

        //should consider passing in "collision" to not have to search for the player object everytime, and just have the formula
        //StartCoroutine(GameManager.Instance.SceneChange(xTarPos, yTarPos, tarDir, scene, collision));
        //Time.timeScale = 0;

        //StartCoroutine(LoadScene());
        
        Bruh = true;
        FadeInStart.Invoke();
    }
    //will just use ^ a screen transition to disguise the freeze (camera fade in and out)
}
