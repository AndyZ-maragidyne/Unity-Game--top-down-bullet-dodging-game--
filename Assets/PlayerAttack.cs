/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
  private float timeBtwAttack;
  public float startTimeBtwAttack;

  public Transform attackPos;
  public LayerMask whatIsEnemies; 
  public float attackRange;

  void Update(){

      if (timeBtwAttack <= 0){

          if(Input.GetKey(KeyCode.Space)){
              Collider2D[] enemiesToDamage = Physics2D.OverlapCircleAll(attackPos.position, attackRange, whatIsEnemies);
              for (int i = 0; i <enemiesToDamage.length; i++){
                  damge = damge;
              }
          }

          timeBtwAttack = startTimeBtwAttack;
      } else {
          timeBtwAttack -= Time.deltaTime;
      }
  }

  void OnDrawGizmosSelected(){

      Gizmos.color = Color.red;
      Gizmos.DrawWireSphere(attackPos.position, attackRange);
  }
}
*/