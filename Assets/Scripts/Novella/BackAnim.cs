using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackAnim : MonoBehaviour
{
    public Animator Animator;
    private void Update()
    {
        if (gameObject.activeSelf)
        {
            Animator.SetBool("isfinish", true);
        }

    }
}
