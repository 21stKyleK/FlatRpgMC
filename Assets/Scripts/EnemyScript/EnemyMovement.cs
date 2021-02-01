using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//v not-abstract because instances are made of it v
public class EnemyMovement : MonoBehaviour
{
        /*Linear; travels a length (cardinal) that doesn't exceed the bounds of the home
     * Diagonal; linear, but with diagonals
     * Free; Diagonal, but in any direction
     * Cardianl; only in cardinal directions
     * Patrol; moves in a straight line, back and forth
     * Teleport; teleports within the range of its home
     * Chase; pathfinding on the player
     * None; enemy stays still, done after battle for a timer, except if its already been registered as stationary
     * Return; go to spawn position
     */

    //tracks coroutine in update
    private bool coRo1 = false;

    //how far they move every frame; how long they wait between movements
    public float mSpd, wL;

    //how long they move mSPd distances, random between range; in case you want the enemy to not move sometimes; reduces speed to not travel across the screen in two seconds
    public float mStamMin, mStamMax, stamMod;

    // switch script when player is in range?
    public bool notLazy;

    //home X and Y, for returning to it; range X and Y, limiting where the enemy can travel (modified so its hit box doesn't stick out)
    float hX, hY, rX, rY;

    //debugging vibration; caused by two scripts
    //int recurCount = 0;

    //Rigidbody2D rb;

    //stores the coroutine to be used by the enemy
    //IEnumerator move;
    
    //scriptableObject with the wanted method; the index of the object from a list?
    public BaseEnemyMove moveType;
    int moveT_index;

    //private HomeData parS;
    void Start()
    {
        //parS = GetComponentInParent<HomeData>();
        //t = (MovementType) 3/*parS.GetMove()*/;
//         SetMoveType(t);

//         Vector2 home = transform.parent.position;

//         hX = home.x; hY = home.y;

//         Vector2 v2 = GetComponentInParent<BoxCollider2D>().size;
//         Vector2 myV2 = GetComponent<CapsuleCollider2D>().size;

        //rX = hX + v2.x - myV2.x; rY = hY + v2.y - myV2.y;
        //home range (x boundaries and y boundaries)
    }

    private void FixedUpdate()
    {
//         if (!coRo1)
//         {
//             coRo1 = true;
//             StartCoroutine(move);
//         }

        //yield return StartCoroutine(DoThing());
    }
    
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //if (!fightOn && collision.transform.tag.Equals("Player"))
        //{
        //    fightOn = true;
            StartCoroutine(GetComponent<ToFightScreen>().enterFight());
        //}
    }
    
    IEnumerator Move(){
        float stam, ang;
        while (coRo1)
        {
            ang = moveType.MakeAngle();

            //if max = min, then will always be min * mod
            stam = (Random.value * (mStamMax - mStamMin) + mStamMin) * stamMod;

            do
            {
            transform.position = (Vector2) transform.position + moveType.Move(mSpd, ang);
//                 Move(ang, mSpd);
//                 yield return null;
                stam -= Time.deltaTime;
                    
            } while (stam > 0);

            yield return new WaitForSeconds(wL);
        }
    }
    
    //changes the type of Movement
    public void SwitchType(){
        coRo1 = false;
    }
    

//     private void Move()
//     {
       // Vector3 bruh = Quaternion.Euler(0, 0, a) * Vector3.up; //going positive (0-360) goes counter clockwise

        //Debug.Log(recurCount++);

       // bruh.Normalize();
       
        //transform.position = ;
        //(GameManager.Instance.CurrentState == (GameManager.States)1) ? (Vector2)(transform.position + bruh * s * Time.deltaTime) : (Vector2) transform.position;

        //rb.MovePosition(new Vector2(transform.position.x + bruh.x * s, transform.position.x + bruh.y * s));
        
        //V works for linear :: may need to change code to accomodatge other types better
        //rb.MovePosition(transform.position + bruh * s);
        //var _ = Quaternion.Euler(x rotation, y rotation, z rotate)
//     }

//     IEnumerator Linear()
//     {
//         float stam, ang;
//         while (coRo1)
//         {
//             ang = (int)(GameManager.Instance.GetRandValueInc() * 4) * 90;

//             //if max = min, then will always be min * mod
//             stam = (GameManager.Instance.GetRandValueInc() * (mStamMax - mStamMin) + mStamMin) * stamMod;

//             do
//             {
//                 Move(ang, mSpd);
//                 yield return null;
//                 stam -= Time.deltaTime;
//             } while (stam > 0);

//             yield return new WaitForSeconds(wL);
//         }
//     }

    //perhaps should use a delegate to store methods (methods might be in GameManager)

    /*
GetRandValueInc()numerator DoThing()
    {
        yield return new WaitForSeconds(1.0f);
        Debug.Log("Waited");
        coRo1 = false;
    }
    */
    //THere will be scripts that inherit method names from this class to have different movement types (sporadic, linear, chase)
    //public EnemyMovement meth;
    //public EnemyMovement Movement { get; }

//     void SetMoveType(MovementType type)
//     {
//         switch (type)
//         {
//             case (MovementType)1:
//                 move = Chase();
//                 break;
//             case (MovementType)2:
//                 move = None();
//                 break;
//             case (MovementType)3:
//                 move = Linear();
//                 break;
//             case (MovementType)4:
//                 move = Diagonal();
//                 break;
//             case (MovementType)5:
//                 move = Freeform();
//                 break;
//             case (MovementType)6:
//                 move = Sporadic();
//                 break;
//             case (MovementType)7:
//                 move = Patrol();
//                 break;
//             case (MovementType)8:
//                 move = Teleport();
//                 break;
//             default:
//                 move = Return();
//                 break;
//         }
//     }
}
