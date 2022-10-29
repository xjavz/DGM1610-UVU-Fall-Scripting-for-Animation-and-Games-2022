using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicBlast : MonoBehaviour
{
   
   public float speed = 30f;
   public int damage = 10;
   public Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();// Reference the rigidbody2D component
        rb.velocity = transform.right * speed; // This line of code add velocity and make gameobject move forward
    }

    // Detect any collision and triggers
    void OnTriggerEnter2D(Collider2D other)
    {
        GhostEnemy enemy = other.GetComponent<GhostEnemy>();
       
        if(other.gameObject.CompareTag("Enemy"))
        {
          enemy.TakeDamage(damage);//Run the TakeDamage function and apply damage to enemy
        }
       
       Destroy(gameObject);// Destroy Projectile

    }
    
}
