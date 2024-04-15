using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Answer : MonoBehaviour
{
    public Speach Speach;

    public void OnClick()
    {

        Speach.showButton();
        StartCoroutine(Speach.ShowText());
        GameManager.pos += 1;
    }
}
