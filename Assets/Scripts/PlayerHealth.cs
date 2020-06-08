using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    public HealthBar healthBar;

    public GameObject deathScreen;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {      
        if(currentHealth <= 0)
        {
            Die();
        }
    }

    public void takeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;
        healthBar.setHealth(currentHealth);        
    }

    private void Die()
    {
        Destroy(this.gameObject);
        deathScreen.SetActive(true);
    }
}
