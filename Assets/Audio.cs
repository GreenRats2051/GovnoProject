using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class Audio : MonoBehaviour
{
    [SerializeField] private AudioMixer MyAudio;
    public void Set(float sliderVal)
    {
        MyAudio.SetFloat("MyExposedParam", Mathf.Log10(sliderVal) *20);
    }
}
