﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public string sceneLoad = "TestingScene1";

    private void Start()
    {
        //call GameManager, which'll create player, then load the scene
        //GameManager.Instance.Throwaway();
        SceneManager.LoadScene(sceneLoad, LoadSceneMode.Additive);

        GameManager.Instance.SetCurrent(sceneLoad);

        //should've been setting the active scene to sceneLoad, but hasn't 9probably because the scene isn't fully loaded whan it reaches thisS
        //SceneManager.SetActiveScene(SceneManager.GetSceneByName(sceneLoad));
        Destroy(this);
    }
}
