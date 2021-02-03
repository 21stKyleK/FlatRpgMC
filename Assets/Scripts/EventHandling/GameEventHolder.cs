using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu]
public class GameEventHolder : ScriptableObject
{
    private readonly List<GameEventEar> hearEvents = new List<GameEventEar>();

    public void RaiseAll()
    {
        //going backwards lets events remove themselves
        for(int i = hearEvents.Count-1; i>=0; i--)
        {
            hearEvents[i].OnEventRaised();
        }
    }

    public void Register(GameEventEar e)
    {
        if(!hearEvents.Contains(e) )
            hearEvents.Add(e);
    }

    public void Unregister(GameEventEar e)
    {
        if (hearEvents.Contains(e))
            hearEvents.Remove(e);
    }
}
