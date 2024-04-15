using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody2D rigidbody2D;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            collision.GetComponent<EnemyAI>().hp--;
        }
    }

    void OnBecameInvisible()
    {
        rigidbody2D.velocity = Vector3.zero;
        transform.position = new Vector3(0, 0, 0);
    }
}
