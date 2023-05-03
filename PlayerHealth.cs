using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    public HealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            takeDamage(10);

            healthBar.setHealth(currentHealth);
            Debug.Log(currentHealth);
        }
    }

    void takeDamage(int damage)
    {
        currentHealth -= damage;
    }

    private void onTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Touching enemy");
            takeDamage(10);
        }
    }

}
