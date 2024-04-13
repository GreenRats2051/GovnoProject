using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public Rigidbody2D rigidbody2D;
    public Vector2 position;
    public float accelerationTime;
    public float speed;
    public float timeLeft;

    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft <= 0)
        {
            position = new Vector2(Random.Range(-1, 1), Random.Range(-1, 1));
            timeLeft += accelerationTime;
        }
        rigidbody2D.velocity = new Vector2(position.x * speed, position.y * speed);
    }

    void OnBecameInvisible()
    {
        transform.position = new Vector3(0, 0, 0);
    }
}