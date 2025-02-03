using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting3 : MonoBehaviour
{   
    public float walkSpeed, range, startTimeBtwAttack;
    private float timeBtwShots;
    private float distToPlayer;

    public Transform firePoint;
    public GameObject bulletPrefab;
    public Transform leafromcrosscode;
    public GameObject bullet;

    public float bulletForce = 20f;

    // Update is called once per frame
    void Update()
    {
        distToPlayer = Vector2.Distance(transform.position, leafromcrosscode.position);
        if(distToPlayer <= range)
        {
            if(timeBtwShots >= startTimeBtwAttack)
            {
            Shoot();
            timeBtwShots = 0;
            }
        }
        timeBtwShots += Time.deltaTime;
    }
    
        void Shoot()
    {
        GameObject newBullet = Instantiate(bullet, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = newBullet.GetComponent<Rigidbody2D>();
        rb.AddForce(leafromcrosscode.position - firePoint.position, ForceMode2D.Impulse);
    }
}
