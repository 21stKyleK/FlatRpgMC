using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//v not-abstract because instances are made of it v
public class EnemyMovement : MonoBehaviour
{
    private enum MovementType
    {
        RETURN, CHASE, NONE, 
        LINEAR, DIAGONAL, FREEFORM, 
        SPORADIC, PATROL, TELEPORT
    }
    //stores movement type so can switch between chasing and normal behaviour
    private MovementType t = (MovementType)1;

    /*Linear; travels a length (cardinal) that doesn't exceed the bounds of the home
     * Diagonal; linear, but with diagonals
     * SuperLine; Diagonal, but in any direction
     * Sporadic; ???
     * Patrol; moves in a straight line, back and forth
     * Teleport; teleports within the range of its home
     * Chase; pathfinding on the player, activates hitbox if turned off
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
    IEnumerator move;

    private HomeData parS;
    void Start()
    {
        parS = GetComponentInParent<HomeData>();
        t = (MovementType) parS.GetMove();
        SetMoveType(t);

        Vector2 home = transform.parent.position;

        hX = home.x; hY = home.y;

        Vector2 v2 = GetComponentInParent<BoxCollider2D>().size;
        Vector2 myV2 = GetComponent<CapsuleCollider2D>().size;

        rX = hX + v2.x - myV2.x; rY = hY + v2.y - myV2.y;

        //rb = GetComponent<Rigidbody2D>();
        //initialize other variables like speed and constraints
        //mSpd /= spdLim;

        //Movement = {whatever in Parent}
        //Movement = this.GetComponent<>();
        //^only for testing, remove component from prefab after testing to see if the format works^
    }

    void SetMoveType(MovementType type)
    {
        switch (type)
        {
            case (MovementType)1:
                move = Chase();
                break;
            case (MovementType)2:
                move = None();
                break;
            case (MovementType)3:
                move = Linear();
                break;
            case (MovementType)4:
                move = Diagonal();
                break;
            case (MovementType)5:
                move = Freeform();
                break;
            case (MovementType)6:
                move = Sporadic();
                break;
            case (MovementType)7:
                move = Patrol();
                break;
            case (MovementType)8:
                move = Teleport();
                break;
            default:
                move = Return();
                break;
        }
    }

    private void FixedUpdate()
    {
        if (!coRo1)
        {
            coRo1 = true;
            StartCoroutine(move);
        }

        //yield return StartCoroutine(DoThing());
    }

    private void Move(float a, float s)
    {
        Vector3 bruh = Quaternion.Euler(0, 0, a) * Vector3.up; //going positive (0-360) goes counter clockwise

        //Debug.Log(recurCount++);

        bruh.Normalize();

        //Debug.Log(bruh);
        //Debug.Log(transform.position);
        //Debug.Log(transform.position + bruh * mSpd);

        //V not linear V
        transform.position = (GameManager.Instance.CurrentState == (GameManager.States)1) ? (Vector2)(transform.position + bruh * s * Time.deltaTime) : (Vector2) transform.position;

        //rb.MovePosition(new Vector2(transform.position.x + bruh.x * s, transform.position.x + bruh.y * s));
        
        //V works for linear :: may need to change code to accomodatge other types better
        //rb.MovePosition(transform.position + bruh * s);
        //var _ = Quaternion.Euler(x rotation, y rotation, z rotate)
    }

    IEnumerator Return()
    {
        yield return null;
    }
    IEnumerator Chase()
    {
        yield return null;
    }

    IEnumerator None()
    {
        yield return null;
    }

    IEnumerator Linear()
    {
        float stam, ang;
        while (coRo1)
        {
            ang = (int)(GameManager.Instance.GetRandValueInc() * 4) * 90;

            //if max = min, then will always be min * mod
            stam = (GameManager.Instance.GetRandValueInc() * (mStamMax - mStamMin) + mStamMin) * stamMod;

            do
            {
                Move(ang, mSpd);
                yield return null;
                stam -= Time.deltaTime;
            } while (stam > 0);

            yield return new WaitForSeconds(wL);
        }
    }

    IEnumerator Diagonal()
    {
        float stam, ang;
        //Debug.Log(recurCount++ +" yeah this is "+this);
        //coRo1 = true;

        while (coRo1)
        {
            ang = (int)(GameManager.Instance.GetRandValueInc() * 8) * 45;

            //if max = min, then will always be min * mod
            stam = (GameManager.Instance.GetRandValueInc() * (mStamMax - mStamMin) + mStamMin) * stamMod;
            //stam = 5;

            do
            {
                Move(ang, mSpd);
                yield return null;
                stam -= Time.deltaTime;
            } while (stam > 0) ;

            yield return new WaitForSeconds(wL);
        }
    }

    IEnumerator Freeform()
    {
        float stam, ang;
        while (coRo1)
        {
            ang = (int) GameManager.Instance.GetRandValueInc() * 360;

            //if max = min, then will always be min * mod
            stam = (GameManager.Instance.GetRandValueInc() * (mStamMax - mStamMin) + mStamMin) * stamMod;

            do
            {
                Move(ang, mSpd);
                yield return null;
                stam -= Time.deltaTime;
            } while (stam > 0);

            yield return new WaitForSeconds(wL);
        }
    }

    IEnumerator Sporadic()
    {
        yield return null;
    }

    IEnumerator Patrol()
    {
        yield return null;
    }

    IEnumerator Teleport()
    {
        yield return null;
    }

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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //if (!fightOn && collision.transform.tag.Equals("Player"))
        //{
        //    fightOn = true;
            StartCoroutine(GetComponent<ToFightScreen>().enterFight());
        //}
    }
}
