using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class UnitShoot : MonoBehaviour
{
    public GameObject enemy;
    public GameObject bullet;
    public Transform startShoot;
    public float bulletSpeed;
    public float rotateUnit;
    public float rotateUnitSpeed;
    public float timeNextShoot;
    public float timeShoot;
    private int speed = 50;
    void Update()
    {
        if(enemy == null)
        {
            enemy = GameObject.FindGameObjectWithTag("Enemy");
        }
        rotateUnit -= rotateUnitSpeed*Time.deltaTime* speed;
        transform.rotation = Quaternion.Euler(0, 0, rotateUnit);
        if (enemy != null)
        {
            timeShoot += Time.deltaTime;
        }
        if(timeShoot >= timeNextShoot)
        {
            if (enemy != null)
            {
                GameObject bulletPrefab = Instantiate(bullet, startShoot.position, Quaternion.identity);
                bulletPrefab.GetComponent<Rigidbody2D>().AddForce(startShoot.right, ForceMode2D.Impulse);
                timeShoot = 0;
            }
        }

    }
}
