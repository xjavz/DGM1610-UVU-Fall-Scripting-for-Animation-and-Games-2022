using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int maxHealth = 10;
    public int currentHealth;
    
    
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        currentHealth = maxHealth;
    }
        public void TakeDamage(int dmgAmount)
    {
        currentHealth -= dmgAmount;
        Debug.Log("Player Health ="+ currentHealth);

        if(currentHealth <= 0)
        {
            Debug.Log("You are dead! Game Over!"); // Game over message in console
            Time.timeScale = 0; // Freeze the game
        }
    }
    
        public void AddHealth(int healAmount)
    {
        currentHealth += healAmount;

        if(currentHealth >= maxHealth)// Puts a cap in current health amount
        {
            currentHealth = maxHealth;
        }
    }
}
