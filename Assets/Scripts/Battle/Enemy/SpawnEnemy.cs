using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public Transform upLeftPos;
    public Transform downRightPos;
    public GameObject enemy;
    public Vector3 position;

    void Start()
    {
        Spawn();
    }

    void Spawn()
    {
        position = new Vector2(Random.Range(upLeftPos.position.x, downRightPos.position.x), Random.Range(upLeftPos.position.y, downRightPos.position.y));
        Instantiate(enemy, position, Quaternion.identity);
    }
}
