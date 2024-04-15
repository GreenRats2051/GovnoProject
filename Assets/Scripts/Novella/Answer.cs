using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Answer : MonoBehaviour
{
    public Speach Speach;
    public void OnClick()
    {
        GameManager.pos += 1;
        Speach.showButton();
    }
}
