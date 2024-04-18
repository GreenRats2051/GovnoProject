using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Shangescen : MonoBehaviour
{
    public string NameScene1;
    public string NameScene2;
    public string NameScene3;
    public void Onclick()
    {

        if (GameManager.posTerapia == 0)
        {
            SceneManager.LoadScene(NameScene1);

        }
        else if (GameManager.posTerapia == 1)
        {
            SceneManager.LoadScene(NameScene2);

        }
        else if(GameManager.posTerapia == 2)
        {
            SceneManager.LoadScene(NameScene3);

        }


    }
}
