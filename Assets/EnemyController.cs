using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform attackPoint;       // Empty child object at the fist/weapon
    public float attackRange = 0.5f;
    public int attackDamage = 10;
    public LayerMask playerLayer;

    void OggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bullet"))
        {
            TakeDamage(collision.GetComponent<BulletScript>().damage);
        }
    }

    public void TakeDamage(int damageAmount)
    {
        int currentHealth = Variables.Object(gameObject).Get<int>("Health");

        currentHealth -= damageAmount;

        Variables.Object(gameObject).Set("Health", currentHealth);

    }

    public void OnAttackHit()
    {
        GameObject player = Variables.Scene(this).Get<GameObject>("Player");

        int playerHealth = Variables.Object(player).Get<int>("Health");
        playerHealth -= attackDamage;
        Variables.Object(player).Set("Health", playerHealth);
    }

}
