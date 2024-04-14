using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePlatform : MonoBehaviour
{
    public float inputAction;
    public float rotatePlatform;
    public float rotatePlatformSpeed;

    void Update()
    {
        inputAction = Input.GetAxis("Horizontal");
        rotatePlatform += inputAction * rotatePlatformSpeed*Time.deltaTime;
        transform.rotation = Quaternion.Euler(0, 0, rotatePlatform);
    }
}
