using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int health;
    private int currentHealth;

    public AudioSource snakeSound;

    //public Healthbar healthbar;


    // Start is called before the first frame update
    void Start()
    {
        currentHealth = health;
        //healthbar.SetMaxHealth(health);
    }

    // Update is called once per frame
    void Update()
    {
        if(currentHealth <= 0)
        {
            Destroy(gameObject);
            snakeSound.enabled = false;

        }
    }

    public void HurtEnemy(int damage)
    {
        currentHealth -= damage;
        //healthbar.SetHealth(currentHealth);

    }
}
