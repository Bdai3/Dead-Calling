using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public int damage = 1;
    // Start is called before the first frame update
    public GameObject hitEffect;
    void OnTriggerEnter2D(Collider2D other)
    {
        switch (other.gameObject.tag)
        {
            case "Wall":
                GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
                Destroy(effect, .5f);
                Destroy(gameObject);
                break;
        }

        if (other.CompareTag("Enemy"))
        {
            other.gameObject.GetComponent<EnemyController>().TakeDamage(damage);
            pointsTracker.Instance.AddScore(10);
            GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
            Destroy(effect, .5f);
            Destroy(gameObject);
        }
    }

}
