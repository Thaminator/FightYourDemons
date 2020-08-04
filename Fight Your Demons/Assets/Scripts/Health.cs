using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] float health = 2f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

    public void DealDamage(float damage)
    {
        health-=damage;
        if(health<=0)
        { 
            Destroy(gameObject); 
        }
    }

}
