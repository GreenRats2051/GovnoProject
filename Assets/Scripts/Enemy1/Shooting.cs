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
    private float shootingTimer;
    private void Awake()
    {
        shootingTimer = Time.time;
    }
    private void Update()
    {
        float distanceToPlayer = Vector3.Distance(firePoint.position, playerTransform.position);

        if (distanceToPlayer <= shootingRange)
        {
            if (Time.time > shootingTimer)
            {
                Shoot();
                shootingTimer = Time.time + shootingInterval;//Возможно тут ошибка
            }
        }
    }

    void Shoot()
    {
        
        GameObject bullet = Instantiate(bulletPrefab, new Vector3(firePoint.localPosition.x, firePoint.localPosition.y, 0), firePoint.localRotation) as GameObject;
        //bullet.GetComponent<Rigidbody2D>().AddForce(new Vector2(playerTransform.position.x- firePoint.position.x, playerTransform.position.y - firePoint.position.y));
        
        bullet.GetComponent<Rigidbody2D>().velocity = (playerTransform.position - firePoint.position).normalized * 10f; 
        Destroy(bullet, 10f);
    }
}
