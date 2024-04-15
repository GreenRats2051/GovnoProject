using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletOneShot : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            collision.GetComponent<EnemyAI>().hp-= 8;
            Destroy(this.gameObject);
        }
    }
}
