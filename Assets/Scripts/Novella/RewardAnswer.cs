using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RewardAnswer : MonoBehaviour
{
    public Speach Speach;
    public void OnClick()
    {
        GameManager.pos += 1;
        GameManager.pils += 1;
        Speach.showButton();
    }
}
