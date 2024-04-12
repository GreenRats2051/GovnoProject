using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunLookCursor : MonoBehaviour
{
    public Vector3 localScale;
    public Vector2 mousePosition;
    public float gunRotate;

    void Start()
    {

    }

    void Update()
    {
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        gunRotate = Mathf.Atan2(mousePosition.y, mousePosition.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, gunRotate);

        if(gunRotate > 90 || gunRotate < -90)
        {
            localScale.y = -1.4f;
        }
        else
        {
            localScale.y = 1.4f;
        }

        transform.localScale = localScale;
    }
}
