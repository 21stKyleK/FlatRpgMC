using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using UnityEngine;

public class EnemyManager
{
    //might want to make singleton
    //public static EnemyManager sing = new EnemyManager();

    //Random ran = new Random();
    //!Must be thread safe, as all the Homes will be calling at a similar time, and if improper, nothing but 0 will be returned!
    //except it appears Unity already does that

    private EnemyManager()
    {

    }

    //this is legal (float Instance {get sing.RandEnemyDouble;} )
    public static EnemyManager Instance
    {
        get;
    } = new EnemyManager();
    
    public float RandEnemyFloat
    {
        get => Random.value;
    }

    //might not need
    
    /*
    public enum Movements
    {
        Linear, Diagonal, Freeform, Patrol, Stationary, Sporadic, Teleport, Chase
    }
    */

    //public static IEnumerator MoveType(int x)
    //{
    //    return moves[x]; 
    //}

    //private static IEnumerator[] moves = { Stationary(), Linear(); };
    
}
