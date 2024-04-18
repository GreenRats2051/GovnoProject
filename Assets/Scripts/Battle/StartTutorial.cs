using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartTutorial : MonoBehaviour
{
    public GameObject TutorialWondow;
    void Start()
    {
        TutorialWondow.SetActive(true);
        Time.timeScale = 0;
    }
    public void Next()
    {
        TutorialWondow.SetActive(false);
        Time.timeScale = 1;
    }
}
