using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform playerTransform;
    private float shootingRange = 1500000000000000000000f;
    public GameObject bulletPrefab;
    public Transform firePoint;

    private float shootingInterval = 15f;
    private float shootingTimer = 10f;

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
        Destroy(bullet, 10f);
    }
}
