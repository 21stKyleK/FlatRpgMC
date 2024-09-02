using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerExMovement : MonoBehaviour
{

    //movement speed and hitbox
    public float mSpd;
    public Rigidbody2D rb;

    //vector object for general movement direction
    private Vector2 mGD = new Vector2(0, 0);

    //small array to hold direction inputs
    //float[] dArray = new float[2];

    private float buffer_Pause = 0;

    //float shiftY;

    //public bool Activity { get; set; } = true;

    // Start is called before the first frame update
    //void Start()
    //{
    //    mGD = new Vector2(0, 0);

    //    //0b10 = 2 in binary, 0x2 = 2 in hexadecimal
    //    dArray = new float[2];
    //}


    // Update is called once per frame, for inputs
    void Update()
    {
        ProcessInputs();
    }

    //for calculations
    void FixedUpdate()
    {
        //if (GameManager.Instance.CurrentState == (GameManager.States)1)
        //{
        //    Activity = true;
        //}
        //else
        //{
        //    Activity = false;
        //}

        Move();
        //Debug.Log(Activity);
    }

    void ProcessInputs()
    {
        //registers if inputs happen (keyboard only registers -1, 0, and 1 for "Raw"), for specific axis
        //if not Raw, then Gravity in input manager actually matters
        //dArray[0] = Input.GetAxisRaw("Horizontal");
        //dArray[1] = Input.GetAxisRaw("Vertical");

        //shiftY = Input.GetAxisRaw("Fire1")+1;

        //Debug.Log(Input.GetAxisRaw("Horizontal") + " " + Input.GetAxisRaw("Vertical"));

        //Vector2.normalized puts vector magnitude at 1, so as to reduce diagonal speed
        mGD = new Vector2( Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;

        //pauses the game, which should bring up the menu UI (ignores enemy timers, which can be resolved with the timers being outside coroutines; should only work on the game field)
        if (Input.GetAxisRaw("Fire1") > 0 && buffer_Pause <= 0)
        {
            StartCoroutine(InputBuffer_Pause());

            if (GameManager.Instance.CurrentState == (GameManager.States)1)
            {
                GameManager.Instance.CurrentState = (GameManager.States)3;
            }
            else if (GameManager.Instance.CurrentState == (GameManager.States)3)
            {
                GameManager.Instance.CurrentState = (GameManager.States)1;
            }
        }
    }

    //use => instead of { for one line methods
    void Move() =>
    //{
        //acceleration calculations should happen here 'cause won't happen at every possible moment
        /*
        for(int i = 2; i<4; i++){
            //should either lead to 1/2 or 1/4 increments, x = new x, new y, x-2 = horizontal, vertical
            dArray[i] = Mathf.Clamp( dArray[i] - ( (dArray[i-2] * -0.125f) + Mathf.Clamp( dArray[i] - (dArray[i] * Mathf.Abs(dArray[i-2]) ), -0.5f, 0.5f ) )  , -1, 1);
        }

        mGD = new Vector2(dArray[2], dArray[3]).normalized;
        */
        //mGD = new Vector2(dArray[0], dArray[1]).normalized;

        //Debug.Log( dArray[0] + " " + dArray[1] );

        //moves the dude
        rb.velocity = (GameManager.Instance.CurrentState == (GameManager.States) 1)? new Vector2(mGD.x * mSpd * Time.deltaTime, mGD.y * mSpd * Time.deltaTime) : new Vector2(0,0);
    //}

    //variables neccesary for location setting and animations, but this isn't neccesary
    //public void SpawnLocation(float xPos, float yPos, byte dir)
    //{
    //    switch (dir)
    //    {
    //        case 1:
    //        case 3:
    //            yPos += spwnOff * (dir - 2);
    //            goto default;
    //        case 2:
    //        case 4:
    //            xPos += spwnOff * (dir - 3);
    //            goto default;
    //        default:
    //            rb.transform.position = new Vector2(xPos, yPos);
    //            break;
    //    }
    //}

    //public void Activity(bool yes)
    //{
    //    enabled = yes;

    //    if (!yes)
    //    {
    //        dArray[0] = 0;
    //        dArray[1] = 0;
    //    }
    //}

    private IEnumerator InputBuffer_Pause()
    {
        buffer_Pause = 0.5f;

        while(buffer_Pause > 0)
        {
            buffer_Pause -= Time.deltaTime;
            yield return null;
        }
    }
}
