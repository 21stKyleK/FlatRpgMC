﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public string sceneLoad;
    public GameObject sceneStart;

    private void Start()
    {
        //call GameManager, which'll create player, then load the scene
        //GameManager.Instance.Throwaway();
        sceneStart.GetComponent<StartScene>().SetCurrentScene(sceneLoad);

        SceneManager.LoadScene(sceneLoad, LoadSceneMode.Additive);

        //SceneManager.SetActiveScene(sceneLoad);

        //GameManager.Instance.SetCurrent(sceneLoad);

        //should've been setting the active scene to sceneLoad, but hasn't 9probably because the scene isn't fully loaded whan it reaches thisS
        //SceneManager.SetActiveScene(SceneManager.GetSceneByName(sceneLoad));

        //Cursor.lockState = CursorLockMode.Locked;
        //Cursor.visible = false;

        Destroy(this);
    }
}
