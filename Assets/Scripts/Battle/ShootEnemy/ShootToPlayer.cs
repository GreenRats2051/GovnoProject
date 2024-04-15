using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootToPlayer : MonoBehaviour
{
    public float timeNextShoot = 2;
    public float timeShoot;
    public GameObject enemy;
    public GameObject bullet;
    public Transform startShoot;
    private void Update()
    {
        if (timeShoot >= timeNextShoot)
        {
            enemy.GetComponent<GameObject>();
            GameObject bulletPrefab = Instantiate(bullet, startShoot.position, Quaternion.identity);
            bulletPrefab.GetComponent<Rigidbody2D>().AddForce((enemy.transform.position - startShoot.position) * 2, ForceMode2D.Impulse);
            timeShoot = 0;

        }
    }
}
