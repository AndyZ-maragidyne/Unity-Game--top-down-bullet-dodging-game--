using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject hitEffect;
    public Transform CircleCenter;
    public LayerMask playerLayers;
    public int attackDamage = 40;

    void OnCollisionEnter2D(Collision2D collision)
    {
        Collider2D[] hitPlayers = Physics2D.OverlapCircleAll(CircleCenter.position, 1f, playerLayers);
        foreach(Collider2D player in hitPlayers)
            {
                Debug.Log("Player got hurt :( ");
                player.GetComponent<Player>().TakeDamage(attackDamage);
            }
        GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
        Destroy(effect, .3f);
        Destroy(gameObject);
    }

}
