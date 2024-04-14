using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class UnitAttack : MonoBehaviour
{
    public float rotateUnit;
    public float rotateUnitSpeed;

    private void Update()
    {
        rotateUnit -= rotateUnitSpeed;
        transform.rotation = Quaternion.Euler(0, 0, rotateUnit);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            collision.GetComponent<EnemyAI>().hp--;
        }
    }
}
