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
    // 0 = no offset, 1-4 = SWNE, direction of spawn displacement

    void OnTriggerEnter2D(Collider2D collision)
    {
        //collision.GetComponent<PlayerMovement>().Activity = false;

        //should consider passing in "collision" to not have to search for the player object everytime, and just have the formula
        //StartCoroutine(GameManager.Instance.SceneChange(xTarPos, yTarPos, tarDir, scene, collision));
        //Time.timeScale = 0;

        //StartCoroutine(LoadScene());
    }
    //will just use ^ a screen transition to disguise the freeze (camera fade in and out)

    /*
     * 
     */
}
