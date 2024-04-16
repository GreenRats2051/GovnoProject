using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public string nameScene;
    public SpawnEnemy spawnEnemy;
    public static int destroyedEnemy = 0;

    void FixedUpdate()
    {
        if (spawnEnemy.maxEnemySpawn <= destroyedEnemy)
        {
            GameManager.posTerapia++;
            GameManager.posAnsvers++;
            GameManager.pos = -1;
            SceneManager.LoadScene(nameScene);

        }
    }
}
