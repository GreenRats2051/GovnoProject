using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RewardAnswer : MonoBehaviour
{
    public Speach Speach;
    public void OnClick()
    {

        GameManager.pils += 1;
        Speach.showButton();
        StartCoroutine(Speach.ShowText());
        GameManager.pos += 1;
    }
}
