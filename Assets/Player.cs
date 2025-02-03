using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public Animator animator;
    public GameObject sword;
    public GameObject LevelController;


    public int maxHealth;
    int currentHealth;
    public bool hard;

    public HealthBar healthBar;
    [SerializeField] private CinemachineVirtualCamera cinemachineVirtualCamera;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.setMaxHealth(maxHealth);
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        animator.SetTrigger("damaged");
        healthBar.setHealth(currentHealth);

        if(currentHealth <= 0)
        {
            StartCoroutine(Die());
        }
    }

    
    public void sethealth(int health)
    {
        maxHealth = health;
        currentHealth = maxHealth;
    }
    IEnumerator Die()
    {
        Debug.Log("Player Died. Wow you suck");
        animator.SetBool("isDead", true);
        GetComponent<Rigidbody2D>().gravityScale = 2;
        GetComponent<Collider2D>().enabled = false;
        GetComponent<PlayerMovement>().enabled = false;
        sword.GetComponent<SwordSwing>().enabled = false;
        cinemachineVirtualCamera.m_Follow = null;
        cinemachineVirtualCamera.m_LookAt = null;
        this.enabled = false;
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(LevelController.GetComponent<LevelController>().getLevel());
    }
}
