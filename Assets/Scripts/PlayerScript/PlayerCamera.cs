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
    private int conX = 0, conY = 0;

    public RawImage fader
    //, bg
    ;

    //IEnumerator bruh;
    
    public UnityEvent FadeInEnd;
    //will trigger the scene change itself

    //void Start()
    //{
    //    //fader.color = new Color(0, 0, 0, 0);
    //    //Debug.Log(this.);
    //}

    private void LateUpdate()
    {
        transform.position = new Vector3(Mathf.Clamp(player.transform.position.x, -conX, conX), Mathf.Clamp(player.transform.position.y, -conY, conY), -10);
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
    public void SetConstraints(int x, int y)
    {
        conX = x;
        conY = y;
    }

    public void Fading(bool toBlack)
    {
        //sbyte fadeDir;

        if (toBlack)
        {
            StartCoroutine(FadeIn());
        }
        else
        {
            StartCoroutine(FadeOut());
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
        //GameManager.Instance.CurrentState = 0;
        //player.GetComponent<PlayerMovement>().Activity = false;
	Time.timeScale = 0;
	//freezes all movement

        while (fader.color.a < 1)
        {
            fader.color = new Color(0, 0, 0, fader.color.a + Time.unscaledDeltaTime);
            yield return null;
        }
	
	FadeInEnd.Invoke();
    }

    //to screen
    public IEnumerator FadeOut()
    {
		//yield return null;

        //Debug.Log("Bruh");
		
        while (fader.color.a > 0)
        {
            fader.color = new Color(0, 0, 0, fader.color.a - Time.unscaledDeltaTime);
            yield return null;
        }
        //player.GetComponent<PlayerMovement>().Activity = true;
        //Debug.Log("ow");
	
	Time.timeScale = 1f;
	//resumes all movement, though may happen elsewhere
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
