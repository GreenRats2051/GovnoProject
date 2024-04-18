using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class StartTutorial : MonoBehaviour
{
    public GameObject TutorialWondow;
    public Button Tutorialbutton;
    public TextMeshProUGUI Tutorialtext;
    void Start()
    {
        TutorialWondow.SetActive(true);
        Time.timeScale = 0;
        StartCoroutine(TutorialbuttonStart());
    }
    private void Update()
    {
        if (GameManager.Language == 0)
        {
            Tutorialtext.text = "Use \"A - D\"  to move platform Use \n\n\"Spase\"  to push platform to center \n\n When ball was follen press \"Lmb\" to launch him \n\n Use \"ctrl\" to stop time and shoot to place that you click";
        }
        else
        {
            Tutorialtext.text = "����������� \"A - D\" ��� ����������� ���������\n\n����������� \"������\" ��� �������� ��������� � �����\n\n����� ��� ����, ������� \"���\", ����� ��������� ���\n\n����������� \"Ctrl\" ��� ��������� ������� � �������� � �����, ���� �� ��������";
        }
    }
    IEnumerator TutorialbuttonStart()
    {
        Tutorialbutton.interactable = false;
        yield return new WaitForSecondsRealtime(3f);
        Tutorialbutton.interactable = true;
        
        
    }

    public void Next()
    {
        TutorialWondow.SetActive(false);
        Time.timeScale = 1;
    }
}
