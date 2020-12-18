using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HomeData : MonoBehaviour
{
    //data for specific enemies, but don't even need spawn manager if I'm putting them all here
    //yeah, 'cause it'd be wierd to have specific homes have different spawn rates going theough a sort of manager if the Homes have it themselves
    //the question is how would I limit the spawns after a KO (might need the spawn manager for that)

    //public GameObject[] scEn;
    //all spawn rates should add up to 100 (each element should be between 0.1 to 100, corresponding Enemy can't be null, but will be Nothing)
    //100 => 1, 0.1 => 0.001 if want to use small numbers
    public float[] spnRt;

    //public byte[] mT;

    //need either index list in here to get a der EnMove script, or have it in the attached enemy (which makes sense, but is it practical)
    //not doing script inheritence for that, just get an index corresponding to 
    int ind;
    //index of the gameobject gotten

    private void Start()
    {
        GameObject e = GetEnemy( (float) System.Math.Round(GameManager.Instance.GetRandValueInc() * 100, 2));
        
        //don't need "this" in situtations such as these, but should use the collider component to define the spawn area
        /*
         * float x = transform.position.x;
           float y = transform.position.y;
        */

        e = Instantiate(e, transform);

        //displaces an enemy by a random amount between the extremes limited by the home's box and their size
        //e.transform.position = new Vector2(e.transform.position.x, e.transform.position.y + 0.5f);
    }

    private GameObject GetEnemy(float x)
    {
        //increases after every unsuccessful return
        float cnt = 0f;

        for (int i = 0; i<spnRt.Length; i++)
        {
            //less than or equal, as x = 100, [n] = 100, then x < [n] wouldn't fire and would go to null which is bad
            //actually, possible for number to return zero, should use +1 for one hundred percent chances
            if (x < spnRt[i] + cnt)
            {
                //returns enemy, like this because they should be the exact same length
                ind = i;
                return GameObject.Find("SceneStarter").GetComponent<StartScene>().en[i];
            }
            cnt += spnRt[i];
        }

        ind = 0;
        //throwaway, as you can't instantiate a null object
        return null;
    }

    public int GetMove()
    {
        return transform.parent.GetComponent<StartScene>().mT[ind];
    }

    public Texture GetImage()
    {
        return transform.parent.GetComponent<StartScene>().bg[ind];
    }
}
