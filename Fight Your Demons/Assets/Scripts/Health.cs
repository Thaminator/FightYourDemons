﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] float health = 1f;
    [SerializeField] GameObject deathVFX;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

     public void DealDamage(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            TriggerDeathVFX();
            Destroy(gameObject);
        }
    }





     private void TriggerDeathVFX()
    {
        if(!deathVFX) { return; }
        GameObject deathVFXObject = Instantiate(deathVFX, transform.position, transform.rotation);
        Destroy(deathVFXObject, 1f);
    }


}
