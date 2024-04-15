using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public TMP_Text text;
    public Rigidbody2D rigidbody2D;
    public NextLevel nextLevel;
    public Vector2 position;
    public float accelerationTime;
    public float speed;
    public float timeLeft;
    public int hp;

    private void Start()
    {
        nextLevel = FindAnyObjectByType<NextLevel>();
    }

    void Update()
    {
        text.text = "HP: " + hp;
        if (hp <= 0)
        {
            nextLevel.destroyedEnemy++;
            Destroy(gameObject);
        }

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