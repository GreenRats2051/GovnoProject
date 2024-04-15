using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public string nameScene;
    public SpawnEnemy spawnEnemy;
    public int destroyedEnemy;

    void FixedUpdate()
    {
        if (spawnEnemy.maxEnemySpawn <= destroyedEnemy)
        {
            SceneManager.LoadScene(nameScene);
        }
    }
}
