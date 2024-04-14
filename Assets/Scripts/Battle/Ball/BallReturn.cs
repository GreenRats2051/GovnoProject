using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallReturn : MonoBehaviour
{
    public Rigidbody2D rigidbody2D;
    public GameObject platform;
    public PlayerHeart PlayerHeart;
    private void Awake()
    {
        transform.parent = platform.transform;
        rigidbody2D.isKinematic = true;
    }
    void OnBecameInvisible()
    {
        transform.position = new Vector3(0, 0, 0);
        transform.parent = platform.transform;
        transform.position = platform.transform.position + new Vector3(0, 0.2f, 0);

        rigidbody2D.velocity = Vector3.zero;
        rigidbody2D.isKinematic = true;
        PlayerHeart.OnHeartLost();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            transform.parent = null;
            rigidbody2D.isKinematic = false;
        }
    }
}
