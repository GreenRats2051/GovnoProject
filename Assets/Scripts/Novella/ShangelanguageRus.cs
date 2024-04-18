using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShangelanguageRus : MonoBehaviour
{

    public void Cange(bool ischange)
    {
        if (ischange)
        {
            GameManager.Language = 1;
        }


    }
}
