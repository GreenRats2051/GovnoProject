using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootToPlayer : MonoBehaviour
{
    public float timeNextShoot = 2;
    private float lastShootTime;
    public GameObject enemy;
    public GameObject bullet;
    public Transform startShoot;
    public int speedofbullet;
    GameObject objWithTag;
    private void Start()
    {
        lastShootTime = Time.time;
    }

    private void Update()
    {
        objWithTag = GameObject.FindWithTag("Player");
        if (Time.time - lastShootTime >= timeNextShoot)
        {
            Shoot();
            lastShootTime = Time.time;
        }
    }

    private void Shoot()
    {
        GameObject bulletPrefab = Instantiate(bullet, startShoot.position, Quaternion.identity);
        Rigidbody2D bulletRb = bulletPrefab.GetComponent<Rigidbody2D>();
        bulletRb.AddForce(( objWithTag.transform.position- startShoot.position) * speedofbullet, ForceMode2D.Impulse);
    }
}
