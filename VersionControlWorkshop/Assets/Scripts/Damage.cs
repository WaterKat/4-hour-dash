using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public int DamageValue = 20;
    private void OnCollisionEnter(Collision collision)
    {
        PlayerHealth enemy = collision.collider.transform.GetComponent<PlayerHealth>();
        if (enemy != null)
        {
            enemy.Health -= DamageValue;

            GetComponent<Collider2D>().enabled = false;
        }
    }
}
