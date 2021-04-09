using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PauseNav : MonoBehaviour
{
    public GameObject targetButton;

    //private void Start()
    //{
    //    EventSystem.current.SetSelectedGameObject(targetButton);
    //}

    public void SetCursor()
    {
        //probably have to use this
        EventSystem.current.SetSelectedGameObject(null);

        EventSystem.current.SetSelectedGameObject(targetButton);
    }

    //might be able to use this in button events
    public void SetCursor(GameObject tb)
    {
        //EventSystem.current.SetSelectedGameObject(null);

        //EventSystem.current.SetSelectedGameObject(tb);

        targetButton = tb;

        SetCursor();
    }
}
