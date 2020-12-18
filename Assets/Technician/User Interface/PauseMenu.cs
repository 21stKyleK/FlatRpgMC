using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    //keeps track of the animation
    bool animCo;

    public float xOut, xIn;

    public GameObject pauseMenu;

    //Awake thing
    private void Awake()
    {
        animCo = false;
    }

    // Update is called once per fram
    void LateUpdate()
    {
        if(GameManager.Instance.CurrentState >= (GameManager.States) 2 && !animCo)
        {
            //Debug.Log("Bromentum");

            animCo = true;
            GetComponent<CanvasGroup>().interactable = true;
            StopAllCoroutines();
            StartCoroutine(MovePause());
        }
        else if(GameManager.Instance.CurrentState <= (GameManager.States)1 && animCo)
        {
            animCo = false;
            GetComponent<CanvasGroup>().interactable = true;
            StopAllCoroutines();
            StartCoroutine(MovePause());
        }
    }

    // (animCo) true, it goes to the right, else it goes to the left
    IEnumerator MovePause()
    {
        float time = 0.3f;
        int cnt = 1;

        while (time > 0)
        {
            if (animCo)
            {
                transform.position = new Vector3(transform.position.x + 40f/cnt++, transform.position.y, transform.position.z);
            }
            else
            {
                transform.position = new Vector3(transform.position.x - 40f / cnt++, transform.position.y, transform.position.z);
            }
            yield return null;
            time -= Time.unscaledDeltaTime;
            //time -= Time.deltaTime;
        }

        if (animCo)
        {
            transform.position = new Vector3(xOut, transform.position.y, transform.position.z);
        }
        else
        {
            transform.position = new Vector3(xIn, transform.position.y, transform.position.z);
        }
    }

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
