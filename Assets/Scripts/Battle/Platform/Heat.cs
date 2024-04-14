using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heat : MonoBehaviour
{
    public bool canstart = true;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && canstart)
        {
            StartCoroutine(Dokik());
            canstart = false;
        }

        IEnumerator Dokik()
        {
            for(int i = 0; i < 10; i++)
            {
                transform.localPosition += new Vector3(0, 0.15f, 0);
                yield return new WaitForSeconds(0.01f);
            }
            for (int i = 0; i < 10; i++)
            {
                transform.localPosition -= new Vector3(0, 0.15f, 0);
                yield return new WaitForSeconds(0.01f);
            }
            canstart = true;
        }
    }

}
