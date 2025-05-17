using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform Player;
    public Collider PlayerCol;
    private Vector3 direction;
    public Rigidbody rb;
    public Health playerHealthObject;
    Animator animator;
    private float moveSpeed = 80f;
    private float chaseSphereRadius = 3f;
    private float attackSphereRadius = 1f;
    private float health = 6f;
    private int count;


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Chasing();
        CheckForAttack();
    }

    void Chasing()
    {
        //Creates a list of all the objects which have collided with the sphere
        Collider[] hitList = Physics.OverlapSphere(transform.position, chaseSphereRadius);
        count = 1;
        //Loops through all the colliders one by one and checks if it is the player
        foreach (var hitCollider in hitList)
        {
           if (hitCollider == PlayerCol && !(animator.GetBool("isAttacking")))
           {
                //Gets the enemy moving towards the player
               direction = Player.position - transform.position;
               rb.velocity = direction.normalized * moveSpeed * Time.deltaTime;
                transform.LookAt(Player.position); 
               //Plays the chasing animation
               animator.SetBool("isChasing", true);
           }
           else if (count == hitList.Length)
           {
                //Stops playing the chasing function, if the player is not in the list
               animator.SetBool("isChasing", false);
           }
           count = count + 1;
        }
    }

    void CheckForAttack()
    {
        //Its the same as the chasing algorithm but now it has a new sphere radius
        Collider[] hitList = Physics.OverlapSphere(transform.position, attackSphereRadius);
        count = 1;
        foreach (var hitCollider in hitList)
        {
           if (hitCollider == PlayerCol)
           {
                //If it is the player, then the enemy attacks
               Attack();
           }
           else if (count == hitList.Length)
           {
                //Resets the animation if the player is not in the range
               animator.SetBool("isAttacking", false);
           }
           count = count + 1;
        }
    }

    void Attack()
    {
        // Attacking animation and player health deduction is executed by this function
        animator.SetBool("isAttacking", true);
        int playerHealth = playerHealthObject.health;
        playerHealthObject.health = playerHealth - 1;
    }

    // This is an in-built method from unity that handles collisions
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "bullet" || (collision.relativeVelocity.magnitude > 1.2 && collision.gameObject.tag == "axe"))
        {
            //Calls the function which takes care of damages
            TakeDamage(collision.gameObject.GetComponent<Colliderdamage>().damage);
        }
    }

    void TakeDamage(int weaponDamage)
    {
        // Deducts the health of the weapon
        this.health -= weaponDamage;
        animator.SetBool("gotHit", true);
        float time = System.Convert.ToSingle(animator.GetCurrentAnimatorClipInfo(0)[0].clip.length - 1.325);
        // This calls the function Hit after the specified time
        Invoke("Hit", time);
        // Check if the enemy needs to die
        if (this.health < 1)
        {
            animator.Play("Monster_anim_Death");
            Invoke("Die", animator.GetCurrentAnimatorClipInfo(0)[0].clip.length + 1);
        }
        Debug.Log(health);
    }

    // Called when the enemy dies
    void Die()
    {
        Destroy(gameObject);
    }

    // Switches off the damage animation
    void Hit()
    {
        animator.SetBool("gotHit", false);
    }
}

    //public float health = 3f;
    //public float chaseDistance;
    //public float attackDistance;
    //float distance;
    //bool inRangeForChasing;
    //bool inRangeForAttacking;

        // distance = Vector3.Distance(Player.position, transform.position);
        // if (distance < chaseDistance)
        // {
        //     if (distance < attackDistance)
        //     {
        //         inRangeForAttacking = true;
        //         inRangeForChasing = false;
        //     }

        //     else
        //     {
        //         inRangeForChasing = true;
        //         inRangeForAttacking = false;
        //     }
        // }

        // else
        // {
        //     inRangeForChasing = false;
        //     inRangeForAttacking = false;
        // }

        // Debug.Log(inRangeForChasing);
        // Debug.Log(inRangeForAttacking);

        // bool isChasing = animator.GetBool("isChasing");
        // bool isAttacking = animator.GetBool("isAttacking");
        // Debug.Log(distance.ToString());
        // if (!isChasing && inRangeForChasing)
        // {
        //     animator.SetBool("isAttacking", false);
        //     animator.SetBool("isChasing", true);
        // }

        // if (isChasing && !inRangeForChasing)
        // {
        //     animator.SetBool("isChasing", false);
        // }
        // if (!isAttacking && inRangeForAttacking)
        // {
        //     animator.SetBool("isAttacking", true);
        //     animator.SetBool("isChasing", false);
        // }
        // if (isAttacking && !inRangeForAttacking)
        // {
        //     animator.SetBool("isAttacking", false);
        // }

        // if (inRangeForChasing)
        // {
        //     transform.LookAt(Player);
        //     Vector3 direction = Player.position - transform.position;
        //     rb.velocity = direction.normalized * moveSpeed * Time.deltaTime;
        // }

        // else
        // {
        //     rb.velocity = Vector3.zero;
        // }