using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToFightScreen : MonoBehaviour
{
	GameObject bruh;
	GameObject cam;

	// Start is called before the first frame update
	void Start()
    {
		bruh = transform.parent.gameObject;
		cam = GameObject.FindGameObjectWithTag("MainCamera");
	}

    // Update is called once per frame
    //void Update()
    //{

    //}

    public IEnumerator enterFight()
    {
		yield return StartCoroutine(cam.GetComponent<PlayerCamera>().FadeIn());
		//no, change the coroutine to public, and make this a coroutine as well

		cam.GetComponent<PlayerCamera>().SetBGImage(GetComponent<EnBattleTactics>().GetTexture());
		//Debug.Log(GetComponent<EnBattleTactics>().GetTexture());

		cam.GetComponent<PlayerCamera>().ActivateBG(true);

		transform.SetParent(GameObject.FindGameObjectWithTag("Canvas").transform, true);
		//the bool is worldPositionStays, where if true, will keep local transform, else it'll inherit from parent
		//transform.position = new Vector3(transform.position.x, transform.position.y, 1007);
		
		//Debug.Log("It is now "+GameManager.Instance.CurrentState);
		
		//StartCoroutine(cam.GetComponent<PlayerCamera>().FadeOut(false));
		
		yield return StartCoroutine(cam.GetComponent<PlayerCamera>().FadeOut());
		
		StartCoroutine(leaveFight(GameManager.Instance.GetRandValueInc() > 0.5f));
		
		//yield return new WaitForSeconds(0.75f);
    }

	public IEnumerator leaveFight(bool destroyMe)
    {

		yield return StartCoroutine(cam.GetComponent<PlayerCamera>().FadeIn());

		cam.GetComponent<PlayerCamera>().ActivateBG(false);

		//StartCoroutine(cam.GetComponent<PlayerCamera>().FadeOut(true));

		cam.GetComponent<PlayerCamera>().Fading(false);


		if (!destroyMe)
        {
            transform.SetParent(bruh.transform, true);
            //transform.position = new Vector2(transform.position.x, transform.position.y);
        }
        else
        {
            Destroy(gameObject);
        }

		//Debug.Log("Epic");
    }
}
