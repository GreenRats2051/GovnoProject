using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public Transform upLeftPos;
    public Transform downRightPos;
    public GameObject[] enemy;
    public Vector3 position;
    public float timeNextSpawn;
    public float timeSpawn;
    public int enemySpawn;
    public int maxEnemySpawn;
    public int idEnemy;

    void Update()
    {
        timeSpawn += Time.deltaTime;
        if(timeSpawn >= timeNextSpawn && enemySpawn < maxEnemySpawn)
        {
            Spawn();
            timeSpawn = 0;
        }
    }

    void Spawn()
    {
        enemySpawn++;
        position = new Vector2(Random.Range(upLeftPos.position.x, downRightPos.position.x), Random.Range(upLeftPos.position.y, downRightPos.position.y));
        idEnemy = Random.Range(0, enemy.Length);
        Instantiate(enemy[idEnemy], position, Quaternion.identity);
    }
}
