using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class PlayerCamera : MonoBehaviour
{
    //should get player component after it is loaded
    public GameObject player;

    //camera constraints; assumes that all scenes are camera sized at least, will have to work around not being able to have non-rectangle rooms and changing visibility based on camera size
    public FloatVar conX, conY;

    public RawImage fader
    //, bg
    ;

    //IEnumerator bruh;

    //is a coroutine running
    private bool yell = false;
    
    public UnityEvent FadeInEnd, FadeOutEnd;
    //will trigger the scene change itself

    //void Start()
    //{
    //    //fader.color = new Color(0, 0, 0, 0);
    //    //Debug.Log(this.);
    //}

    private void LateUpdate()
    {
        transform.position = new Vector3(Mathf.Clamp(player.transform.position.x, -conX, conX), Mathf.Clamp(player.transform.position.y, -conY, conY), -20);
    }

    /*
     void SomeUpdate(){
        //transform is the perma-component for tracking object positions, which is how you get positions from either instances or prefabs
        //may need + new Vector#() to offset away from player
        transform.position = playerAll.transform.position ;
        //need to get size of scenes, which can be variable in script, object optional, so as to retrict (camera) movement
    }
     */

    //these could be properties instead...
    public void SetConstraints(float x, float y)
    {
        conX.SetValue(x);
        conY.SetValue(y);
    }

    //actually, would have all the methods happen instantly

    //public void FadeChangeScene()
    //{
    //    Time.timeScale = 0;
    //    Fading(true);
    //    FadeInEnd.Invoke();
    //}

    //public void FadeEndTran()
    //{
    //    Fading(false);
    //    Time.timeScale = 1f;
    //    FadeOutEnd.Invoke();
    //}

    public void Fading(bool toBlack)
    {
        //sbyte fadeDir;

        if (toBlack)
        {
            StartCoroutine(FadeSceneStart());
        }
        else
        {
            StartCoroutine(FadeSceneEnd());
        }

        //bruh = FadeImage(fadeDir);

        //StartCoroutine(FadeImage(fadeDir));

        //while(bruh != null) { 
        //    Debug.Log("brother "+Time.time);
        //}

        //return new WaitUntil(StartCoroutine(FadeImage(fadeDir)););
        //^waiting for coroutines will freexe your everything^
    }

    //uses the Raw Image, probably could make these public
    //to black
    public IEnumerator FadeIn()
    {
        yell = true;

        //GameManager.Instance.CurrentState = 0;
        //player.GetComponent<PlayerMovement>().Activity = false;
        //Time.timeScale = 0;
        //freezes all movement

        while (fader.color.a < 1)
        {
            fader.color = new Color(0, 0, 0, fader.color.a + Time.unscaledDeltaTime);
            yield return null;
        }

        yell = false;

        //FadeInEnd.Invoke();
    }

    //to screen
    public IEnumerator FadeOut()
    {
        yell = true;
		//yield return null;

        //Debug.Log("Bruh");
		
        while (fader.color.a > 0)
        {
            fader.color = new Color(0, 0, 0, fader.color.a - Time.unscaledDeltaTime);
            yield return null;
        }
        //player.GetComponent<PlayerMovement>().Activity = true;
        //Debug.Log("ow");

        //Time.timeScale = 1f;
        //resumes all movement, though may happen elsewhere

        //FadeOutEnd.Invoke();
        yell = false;
    }

    public IEnumerator FadeSceneStart()
    {
        Time.timeScale = 0;

        StartCoroutine(FadeIn());

        while (yell)
        {
            yield return null;
        }

        FadeInEnd.Invoke();
    }

    public IEnumerator FadeSceneEnd()
    {
        //Time.timeScale = 1;

        StartCoroutine(FadeOut());

        while (yell)
        {
            yield return null;
        }

        Time.timeScale = 1;

        FadeOutEnd.Invoke();
    }

    //might need to make different IEnumerators for entering fight scenes

    /*
        public void SetBGImage(Texture bruh)
        {
            bg.texture = bruh;
        }

        public void ActivateBG(bool bruh)
        {
            bg.enabled = bruh;
        }
        */
}
