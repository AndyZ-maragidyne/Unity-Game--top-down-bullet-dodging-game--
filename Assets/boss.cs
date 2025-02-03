using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss : MonoBehaviour
{
    public Animator animator;
    public HealthBar healthBar;

    public int maxHealth = 100;
    public int currentHealth;
    
    // Start is called before the first frame update

        void Start()
        {
            healthBar.setMaxHealth(maxHealth);
        }

  void Update()
    {
        currentHealth = GetComponent<Enemy>().currentHealth;
        if(currentHealth<=320)
        {
            GetComponent<Shooting>().enabled = false;
        }

        if(currentHealth <= 240)
        {
            GetComponent<Shooting5>().enabled = false;
        }

        if (currentHealth <= 160)
        {
            GetComponent<Shooting2>().enabled = false;
        }

        if(currentHealth <= 80)
        {
            GetComponent<Shooting4>().enabled = false;
            GetComponent<shooting3>().startTimeBtwAttack = 0;
        }
        healthBar.setHealth(currentHealth);
    }

}

