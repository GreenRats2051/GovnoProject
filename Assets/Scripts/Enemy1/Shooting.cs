using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform playerTransform;
    public float shootingRange = 150f;
    public GameObject bulletPrefab;
    public Transform firePoint;

    public float shootingInterval = 15f;
    private float shootingTimer;

    private void Update()
    {
        float distanceToPlayer = Vector3.Distance(firePoint.position, playerTransform.position);

        if (distanceToPlayer <= shootingRange)
        {
            if (Time.time >= shootingTimer)
            {
                Shoot();
                shootingTimer = Time.time + shootingInterval;//Возможно тут ошибка
            }
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        bullet.GetComponent<Rigidbody>().velocity = (playerTransform.position - firePoint.position).normalized * 10f; //Возможно тут ошибка
        Destroy(bullet, 1f);
    }
}
