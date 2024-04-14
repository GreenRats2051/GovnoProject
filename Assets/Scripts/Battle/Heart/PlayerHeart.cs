using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHeart : MonoBehaviour
{
    int HeartPoints = 7;
    
    public List<Image> Hearts = new List<Image>();
    public void OnHeartLost()
    {
        Hearts[HeartPoints].fillAmount -= 0.5f;
        if (Hearts[HeartPoints].fillAmount == 0)
        {
            HeartPoints -= 1;
        }
    }

}
