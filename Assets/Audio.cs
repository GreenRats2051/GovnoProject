using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Audio : MonoBehaviour
{
    Slider Slider;
    private void Update()
    {
        Slider.GetComponent<Slider>();
        AudioListener.volume = Slider.value;
    }
}
