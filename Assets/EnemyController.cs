using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    // Start is called before the first frame update
    public int health;

    void OggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bullet")
        {
            TakeDamage(collision.GetComponent<BulletScript>().damage);
        }
    }

    public void TakeDamage(int damageAmount)
    {
        // Read current health
        int currentHealth = Variables.Object(gameObject).Get<int>("Health");

        // Subtract damage
        currentHealth -= damageAmount;

        // Write it back
        Variables.Object(gameObject).Set("Health", currentHealth);

    }

}
