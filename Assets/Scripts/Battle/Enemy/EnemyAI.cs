using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public Transform[] point;
    public TMP_Text text;
    public Rigidbody2D rigidbody2D;
    public Vector2 position;
    public float distance;
    public float speed;
    public int idPoint;
    public int hp;

    void Start()
    {
        point[0] = GameObject.FindWithTag("Point1").transform;
        point[1] = GameObject.FindWithTag("Point2").transform;
        point[2] = GameObject.FindWithTag("Point3").transform;
        point[3] = GameObject.FindWithTag("Point4").transform;
        idPoint = Random.Range(0, point.Length);
    }

    void Update()
    {
        text.text = "HP: " + hp;
        if (hp <= 0)
        {
            Destroy(gameObject);
        }
        distance = Vector2.Distance(point[idPoint].position, this.gameObject.transform.position);
        if (distance <= 1)
        {
            idPoint = Random.Range(0, point.Length);
        }
        transform.position = Vector2.MoveTowards(transform.position, point[idPoint].position, speed * Time.deltaTime);
    }

    void OnBecameInvisible()
    {
        transform.position = new Vector3(0, 0, 0);
    }
}