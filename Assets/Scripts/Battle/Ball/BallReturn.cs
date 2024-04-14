using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallReturn : MonoBehaviour
{
    public Rigidbody2D rigidbody2D;

    void OnBecameInvisible()
    {
        transform.position = new Vector3(0, 0, 0);
        rigidbody2D.velocity = Vector3.zero;
    }
}
