using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class BallDamage : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            collision.GetComponent<EnemyStats>().hp--;
            collision.transform.DOPunchRotation(new Vector3(0,45,0),1.5f);


        }
    }
}
