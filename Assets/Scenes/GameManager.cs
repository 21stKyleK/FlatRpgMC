using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager
{
    private string cS;

    private GameObject cam;

    //private readonly string preName = "Player";

    //private constructor so it can only be called inside this
    private GameManager()
    {
        /*
        Debug.Log("GameManager constructed: cS = " + cS + ", preName = " + preName);

        //!!! shouldn't be initialized in a scene that isn't just PermaStuff
        //something Instaniate(Resources.Load(preName)) ?

        SceneManager.LoadSceneAsync(cS, LoadSceneMode.Additive);
        */

        cam = GameObject.FindGameObjectWithTag("MainCamera");
    }

    public void Throwaway()
    {
        //does nothing, lets GameManager initialize without destroying stuff, this may not be neccesary as Title Screen is developed
        //also this can't be static
    }

    //the only way to access this abomination
    public static GameManager Instance {
        //super shorthand, only if nothing else is to be done
        get;

    //get
    //{
    //    if (sing == null)
    //    {
    //        sing = new GameManager();
    //    }
    //    return sing;
    //}
    } = new GameManager();

    //set current scene
    public void SetCurrent(string s) => cS = s;

    public States CurrentState { get; set; } = (States) 1;

    //public void BruhMoment(float x, float y, byte d, string tS, Collider2D col) => StartCoroutine(SceneChange(float x, float y, byte d, string tS, Collider2D col));

    public float GetRandValueInc()
    {
        return UnityEngine.Random.value;
    }

    //pause stuff, game states, and (maybe) scene transitions

    //unloads the current playfield, moves the player, and loads the new playfield
    //target x, target y, displace direction, target scene, current scene (probably can put in here)
    public IEnumerator SceneChange(float x, float y, byte d, string tS, Collider2D col)
    {
        //Debug.Log(cS);
        //col is disabled in LoadZoneTrigger

        //camera fade in
        //yield return StartCoroutine( cam.GetComponent<PlayerCamera>().FadeIn() );
        cam.GetComponent<PlayerCamera>().Fading(true, false);

        //Debug.Log(cS);

        yield return new WaitForSeconds(1f);

        //Debug.Log(cS);
        //GameObject p = GameObject.Find(preName);
        //PlayerMovement s = GameObject.Find(preName).GetComponent<PlayerMovement>();

        SceneManager.UnloadSceneAsync(cS);

        //Debug.Log(cS);
        //p.GetComponent<PlayerMovement>().SpawnLocation(x, y, d);
        //s.SpawnLocation(x, y, d);
        //may need to rewrite this thing to include animation directions
        col.GetComponent<Rigidbody2D>().transform.position = new Vector2(x, y);

        //Debug.Log(cS);

        SceneManager.LoadSceneAsync(tS, LoadSceneMode.Additive);
        //SceneManager.SetActiveScene(SceneManager.GetSceneByName(tS));

        //Debug.Log(cS);

        SetCurrent(tS);

        //Debug.Log(cS);

        //camera fade out
        //yield return StartCoroutine( cam.GetComponent<PlayerCamera>().FadeOut(true) );
        cam.GetComponent<PlayerCamera>().Fading(false, true);

        //Debug.Log(cS);

        //yield return new WaitForSeconds(1f);

        //Debug.Log(cS);

        //col.GetComponent<PlayerMovement>().Activity = true;

        //Debug.Log(cS);
    }

    //possible game states
    public enum States
    {
        FREEZE, GAME_FIELD, 
        GAME_FIGHT, MENU_PAUSE,
        MENU_MAIN
    }

    /*FREEZE: freezes all movement, disables menus
     * GAME_FIELD: overworld, where fights are initiated, the player can interact with things, and scenes usually transition
     * GAME_FIGHT: turn-based combat, takes place mostly in the UI, uses menu navigation
     * MENU_PAUSE: save game, access inventory, check stats; for the overworld
     * MENU_MAIN: title screen and what not
     */
}
