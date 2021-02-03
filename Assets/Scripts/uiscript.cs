using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class uiscript : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth = 100;

    public Slider healthBar;

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.maxValue = maxHealth;
        healthBar.value = maxHealth;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            TakeDamage(20);
        }    
    }
    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.value = currentHealth;
    }
}
