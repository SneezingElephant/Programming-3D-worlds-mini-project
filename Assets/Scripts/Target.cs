using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    
    //Assign variables for the different Target parameters

    private static float minHealth = 10f;
    private static float maxHealth = 99f;

    private int killReward = 1;

    public float health;

    
    private void Update()
    {
        
    }


    private void Start()
    {
        //Assign a random health variable in the given range for every spawned enemy
        
        health = Random.Range(minHealth, maxHealth);
        
       
    }

    public void TakeDamage(float amount)
    {
        
        //Assign point and disappear upon death
        
        health -= amount;
        if (health <= 0f)
        {
            ScoreCounter.score += killReward;
            Die(); 
        }

    }

    void Die()
    {
        Destroy(gameObject);
        
    }
}
