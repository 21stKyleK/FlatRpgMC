using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetCohorts : MonoBehaviour
{
    public ObjectRTS enemies;

    public GameObjectVar en;

    private int i = 0;

    public void SetEnemies(/*List<GameObject> l*/)
    {
        //enemies.Set(l);
        i = 0;

        CreateEnemies();
    }

    public void CreateEnemies()
    {
        GameObject bruh = Instantiate(enemies.GetThing(i));

        bruh.GetComponent<RectTransform>().anchoredPosition = new Vector2(713.5f, 712.5f);

        //use foreach in final
    }

    public Fighter GetFighter() =>
    //{
        /*return*/ GetObject().GetComponent<Fighter>();
    //}

    public Button GetButton() =>
        GetObject().GetComponent<Button>();

    //only need this for Pause Nav, though probably a B to get over there
    public GameObject GetObject() =>
        enemies.GetThing(i);

    public void ActivateButton() =>
        GetButton().interactable = true;

    public void DeactivateButton() =>
        GetButton().interactable = false;

    public void Remove()
    {
        GameObject des = GetObject();

        enemies.Remove(des);

        Destroy(des);
    }

    public void RemoveAll()
    {
        i = 0;

        while (enemies.GetLength() > 0)
        {
            Remove();
        }
    }

    public void OnDestroy() =>
        enemies.ClearOut();
}
