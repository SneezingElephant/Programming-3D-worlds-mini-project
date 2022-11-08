using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private static float minHealth = 10f;
    private static float maxHealth = 99f;


    public float health;

    

    private void Start()
    {
        health = Random.Range(minHealth, maxHealth);
    }

    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            Die();
        }

    }

    void Die()
    {
        Destroy(gameObject);
    }
}
