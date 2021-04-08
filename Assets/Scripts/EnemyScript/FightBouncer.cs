using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
//using UnityEngine.UI;

public class FightBouncer : MonoBehaviour
{
    public UnityEvent Encountered;

    public ImageSO bg;

    public Color bgc;

    //probably better off with a list of some ScriptableObject
    public Sprite l1, l2, l3;

    //public List<Fighter> cohorts;
    //might want to make regular game objects so can prefab easier
    public List<GameObject> cohorts;

    private void OnCollisionEnter2D(Collision2D col)
    {
        //Debug.Log(enabled);

        if (enabled) {
            //Time.timeScale = 0;

            bg.SetColor(bgc);

            bg.SetLayer1(l1);
            bg.SetLayer2(l2);
            bg.SetLayer3(l3);

            Encountered.Invoke();

            //disabling this script will prevent future run-ins until turned on

            enabled = false;
        }
    }

    //entrance from event to handle the enemy after a fight is over
    public void PostFightBreak(bool peace)
    {
        StartCoroutine(Afterwards(peace));
    }

    //if not peace, then destroy object, else enabled = true;
    public IEnumerator Afterwards(bool peace)
    {
        //Debug.Log("bruh");

        yield return new WaitForSeconds(0.5f);

        //Debug.Log("bruh 2");

        if (peace)
        {
            //Debug.Log("bruh 3");

            enabled = peace;
        }
        else
        {
            //Debug.Log("bruh 4");

            Destroy(gameObject);
        }

        //Debug.Log("bruh 2");
    }
}
