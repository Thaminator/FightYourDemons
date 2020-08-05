using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] float speed = 1f;
    [SerializeField] float damage = 2f;


    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);

    }

    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        var health = otherCollider.GetComponent<Health>();
        var attacker = otherCollider.GetComponent<Attacker>();

        if (attacker && health) 
        { 
        health.DealDamage(damage);
            Destroy(gameObject);

        }
    }



    }
