using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public PlayerHeart PlayerHeart;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            PlayerHeart.OnHeartLost();
            Destroy(this.gameObject);

        }
    }
    private void OnBecameInvisible()
    {
        Destroy(this.gameObject);

    }
    private void Start()
    {
        PlayerHeart = FindAnyObjectByType<PlayerHeart>();
    }
}
