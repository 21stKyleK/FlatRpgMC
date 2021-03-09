using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleAnimation : PauseMenu {
    
    new public void DoAnim()
    {

    }

    IEnumerator MovePause()
    {
        //cantPause.SetValue(true);

        cantDo.SetValue(true);
        float time = baseTime;
        int cnt = 1;

        while (time > 0)
        {
            if (!menuOut)
            {
                pauseMenu.transform.position = new Vector3(pauseMenu.transform.position.x, pauseMenu.transform.position.y + howFast / cnt++, pauseMenu.transform.position.z);
            }
            else
            {
                pauseMenu.transform.position = new Vector3(pauseMenu.transform.position.x, pauseMenu.transform.position.y - howFast / cnt++, pauseMenu.transform.position.z);
            }
            yield return null;
            time -= Time.unscaledDeltaTime;
            //time -= Time.deltaTime;

            //Time.timeScale = 0;
        }

        if (menuOut)
        {
            pauseMenu.transform.position = new Vector3(pauseMenu.transform.position.x, inPos, pauseMenu.transform.position.z);
            menuOut = false;
        }
        else
        {
            pauseMenu.transform.position = new Vector3(pauseMenu.transform.position.x, outPos, pauseMenu.transform.position.z);
            menuOut = true;
        }

        cantDo.SetValue(false);

        //cantPause.SetValue(false);
    }
}
