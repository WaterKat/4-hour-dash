using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public int DamageValue = 20;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        PlayerHealth enemy = collision.collider.transform.GetComponent<PlayerHealth>();
        if (enemy != null)
        {
            enemy.Health -= DamageValue;
            enemy.TakeDamageAnimation();
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(-5, 10);
                GetComponent<Rigidbody2D>().angularVelocity = 1000;
            }
            GetComponent<Collider2D>().enabled = false;
            Destroy(this);
        }
    }
}
