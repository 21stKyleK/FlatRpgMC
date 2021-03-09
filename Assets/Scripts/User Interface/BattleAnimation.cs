using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleAnimation : PauseMenu {

    private RectTransform bad;

    private void Start()
    {
        bad = pauseMenu.GetComponent<RectTransform>();
    }

    new public void DoAnim()
    {
        if (!cantDo)
        {
            pauseMenu.GetComponent<CanvasGroup>().interactable = menuOut ? false : true;

            StartCoroutine(MovePause());
        }
    }

    new public void CantDo()
    {
        StopAllCoroutines();
        bad.anchoredPosition = new Vector2(bad.anchoredPosition.x, inPos);
        pauseMenu.GetComponent<CanvasGroup>().interactable = false;
        menuOut = false;
        //cantDo.SetValue(true);
        //Debug.Log("oh");
    }

    private IEnumerator MovePause()
    {
        cantDo.SetValue(true);
        float time = baseTime;
        int cnt = 1;

        while (time > 0)
        {
            if (!menuOut)
            {
                bad.anchoredPosition -= new Vector2(0, howFast / cnt++);
            }
            else
            {
                bad.anchoredPosition += new Vector2(0, howFast / cnt++);
            }
            yield return null;
            time -= Time.unscaledDeltaTime;
        }

        if (menuOut)
        {
            bad.anchoredPosition = new Vector2(bad.anchoredPosition.x, inPos);
            menuOut = false;
        }
        else
        {
            bad.anchoredPosition = new Vector2(bad.anchoredPosition.x, outPos);
            menuOut = true;
        }

        cantDo.SetValue(false);
    }
}
