using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    //keeps track of the animation, if the animation can happen now
    public bool menuOut = false, canDo = true;

    //public BoolVar cantPause;

    public float baseTime = 0.3f, howFast = 40f;

    public float xOut, xIn;

    public GameObject pauseMenu;

    public void DoAnim()
    {
        if (canDo)
        {
            //if (menuOut)
            //{
            //    //Time.timeScale = 0;
            //    pauseMenu.GetComponent<CanvasGroup>().interactable = true;
            //}
            //else
            //{
            //    //Time.timeScale = 1;
            //    pauseMenu.GetComponent<CanvasGroup>().interactable = false;
            //}

            pauseMenu.GetComponent<CanvasGroup>().interactable = menuOut ? false : true;

            StartCoroutine(MovePause());
        }
    }

    public void CantDo()
    {
        StopAllCoroutines();
        pauseMenu.transform.position = new Vector3(xIn, pauseMenu.transform.position.y, pauseMenu.transform.position.z);
        canDo = false;
    }

    public void CanDo()
    {
        canDo = true;
    }

    // (menuOut) true, it goes to the right, else it goes to the left
    IEnumerator MovePause()
    {
        //cantPause.SetValue(true);

        canDo = false;
        float time = baseTime;
        int cnt = 1;

        while (time > 0)
        {
            if (!menuOut)
            {
                pauseMenu.transform.position = new Vector3(pauseMenu.transform.position.x + howFast/cnt++, pauseMenu.transform.position.y, pauseMenu.transform.position.z);
            }
            else
            {
                pauseMenu.transform.position = new Vector3(pauseMenu.transform.position.x - howFast / cnt++, pauseMenu.transform.position.y, pauseMenu.transform.position.z);
            }
            yield return null;
            time -= Time.unscaledDeltaTime;
            //time -= Time.deltaTime;

            //Time.timeScale = 0;
        }

        if (menuOut)
        {
            pauseMenu.transform.position = new Vector3(xIn, pauseMenu.transform.position.y, pauseMenu.transform.position.z);
            menuOut = false;
        }
        else
        {
            pauseMenu.transform.position = new Vector3(xOut, pauseMenu.transform.position.y, pauseMenu.transform.position.z);
            menuOut = true;
        }

        canDo = true;

        //cantPause.SetValue(false);
    }

    //Awake thing
    //private void Awake()
    //{
    //    menuOut = false;
    //}

    // Update is called once per fram
    //void LateUpdate()
    //{
    //    if(Time.timeScale < 0 && !menuOut)
    //    {
    //        //Debug.Log("Bromentum");

    //        menuOut = true;
    //        GetComponent<CanvasGroup>().interactable = true;
    //        StopAllCoroutines();
    //        StartCoroutine(MovePause());
    //    }
    //    else if(Time.timeScale > 1 && menuOut)
    //    {
    //        menuOut = false;
    //        GetComponent<CanvasGroup>().interactable = true;
    //        StopAllCoroutines();
    //        StartCoroutine(MovePause());
    //    }
    //}

    //public void Update()
    //{
    //    if (canDo && Input.GetAxisRaw("Fire1") > 0)
    //    {
    //        if (menuOut)
    //        {
    //            Time.timeScale = 0;
    //            pauseMenu.GetComponent<CanvasGroup>().interactable = true;
    //        }
    //        else
    //        {
    //            Time.timeScale = 1;
    //            pauseMenu.GetComponent<CanvasGroup>().interactable = false;
    //        }
    //        DoAnim();
    //    }
    //}

    //Animator pause;

    ////bool pauseOn = false;
    //int pause_Hash = Animator.StringToHash("Base Layer.PauseOn");
    //int pause_Hash_mirror = Animator.StringToHash("Mirrored");
    //int pause_Hash_trigger = Animator.StringToHash("Menu_Pause");

    //private void Start()
    //{
    //    pause = GetComponent<Animator>();
    //}

    //private void FixedUpdate()
    //{
    //    AnimatorStateInfo bruh = pause.GetCurrentAnimatorStateInfo(0);

    //    if ((GameManager.Instance.CurrentState == (GameManager.States)3 && pause_Hash == bruh.fullPathHash) || (GameManager.Instance.CurrentState != (GameManager.States)3 && pause_Hash != bruh.fullPathHash))
    //    {
    //        pause.ResetTrigger(pause_Hash_trigger);

    //    }

    //    //if space was pressed and the current state isn't pause
    //    if (GameManager.Instance.CurrentState == (GameManager.States)3 && pause_Hash != bruh.fullPathHash)
    //    {
    //        //Debug.Log(bruh.fullPathHash);

    //        GetComponent<CanvasGroup>().interactable = true;
    //        pause.SetBool(pause_Hash_mirror, false);
    //        pause.SetTrigger(pause_Hash_trigger);

    //    }
    //    else if (GameManager.Instance.CurrentState != (GameManager.States)3 && pause_Hash == bruh.fullPathHash)
    //    {
    //        //Debug.Log(bruh.fullPathHash);

    //        GetComponent<CanvasGroup>().interactable = false;
    //        pause.SetBool(pause_Hash_mirror, true);
    //        pause.SetTrigger(pause_Hash_trigger);
    //    }
    //}
}
