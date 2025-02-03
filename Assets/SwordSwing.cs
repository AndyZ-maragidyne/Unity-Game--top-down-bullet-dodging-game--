using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordSwing : MonoBehaviour
{
   public Animator animator;
    Vector2 position;

    public Transform attackPoint1;
    public Transform attackPoint2;
    //public Transform attackPoint2;
    public float attackRange = 0.5f;
    public LayerMask enemyLayers;

    public int attackDamage = 40;

    //private float timeBtwAttack = 0;
  //public float startTimeBtwAttack;

    void Update()
    {

        if(Input.GetKey(KeyCode.Space)){
            
            animator.SetBool("spacePressed", true);
            //animator.Play("sword_attack");
            //Attack();
                
        } else{
            animator.SetBool("spacePressed", false);
        }

        
        if(Input.GetKey(KeyCode.A)){
            animator.SetBool("left", true);
            animator.SetBool("right", false);
            animator.SetBool("up", false);
            animator.SetBool("down", false);
        }

        if(Input.GetKey(KeyCode.W)){
            animator.SetBool("left", false);
            animator.SetBool("right", false);
            animator.SetBool("up", true);
            animator.SetBool("down", false);
        }

        if(Input.GetKey(KeyCode.S)){
            animator.SetBool("left", false);
            animator.SetBool("right", false);
            animator.SetBool("up", false);
            animator.SetBool("down", true);
        }

        if(Input.GetKey(KeyCode.D)){
            animator.SetBool("left", false);
            animator.SetBool("right", true);
            animator.SetBool("up", false);
            animator.SetBool("down", false);
        }

    
    }
/*
    void Attack()
    {
        Collider2D[] hitEnemies = Physics2D.OverlapAreaAll(attackPoint1.position, attackPoint2.position, enemyLayers);
        foreach(Collider2D enemy in hitEnemies)
        {
            Debug.Log("Enemy got hurt :( ");
            enemy.GetComponent<Enemy>().TakeDamage(attackDamage);
        }
    }
*/
    void OnDrawGizmosSelected()
    {
        if (attackPoint1 == null)
         return;
        //Gizmos.DrawWireSphere(attackPoint1.position, attackRange);
    }

    public void Attack()
    {
        Collider2D[] hitEnemies = Physics2D.OverlapAreaAll(attackPoint1.position,attackPoint2.position, enemyLayers);
            foreach(Collider2D enemy in hitEnemies)
            {
                Debug.Log("Enemy got hurt :( ");
                enemy.GetComponent<Enemy>().TakeDamage(attackDamage);
            }
    }
}

