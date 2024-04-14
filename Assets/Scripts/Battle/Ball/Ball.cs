using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody2D rigidbody2D;
    public InventoryAndStats inventoryAndStats;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            collision.GetComponent<EnemyAI>().hp--;
        }
    }

    void OnBecameInvisible()
    {
        inventoryAndStats.hp--;
        rigidbody2D.velocity = Vector3.zero;
        transform.position = new Vector3(0, 0, 0);
    }
}
