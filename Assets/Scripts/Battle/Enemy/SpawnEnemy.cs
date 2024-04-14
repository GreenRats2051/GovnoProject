using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public Transform upLeftPos;
    public Transform downRightPos;
    public GameObject enemy;
    public Vector3 position;
    GameObject enemyOnScrin;
    float spawntime ;

    private void Update()
    {
        if (enemyOnScrin == null)
        {
            spawntime = Time.time;
            if (Time.time - spawntime > 3f)
            {
                Spawn();
            }

        }
    }

    void Spawn()
    {
        position = new Vector2(Random.Range(upLeftPos.position.x, downRightPos.position.x), Random.Range(upLeftPos.position.y, downRightPos.position.y));
        enemyOnScrin = Instantiate(enemy, position, Quaternion.identity);
    }
}
