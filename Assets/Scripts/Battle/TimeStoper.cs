using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeStoper : MonoBehaviour
{
    [SerializeField]public Image TimeStopControl;
    public bool isreload = true;
    public bool isfire = false;
    public Vector3 mousePos;
    public Vector3 mousePosClick = new Vector3(0,0,0);
    public GameObject bullet;
    public Transform SpawnBuletpoint;
    private int bulet_Speed=3;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl)&& isreload)
        {
            TimeStopControl.fillAmount = 0;
            Time.timeScale = 0;
            isreload = false;
            
            
        }
        else if (TimeStopControl.fillAmount ==1)
        {
            isreload = true;
            
        }

        if(isfire)
            TimeStopControl.fillAmount += 0.1f * Time.deltaTime;

        if (!isreload && !isreload)
        {
            OnTimeStop();
        }
       
    }
    public void OnTimeStop()
    { 
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (Input.GetMouseButtonDown(0))
            {
                mousePosClick = mousePos;
                Debug.Log(mousePosClick);
                Time.timeScale = 1;
                isfire = true;
                GameObject bulletPrefab = Instantiate(bullet, SpawnBuletpoint.position, Quaternion.identity);
                bulletPrefab.GetComponent<Rigidbody2D>().AddForce( (mousePosClick - SpawnBuletpoint.position)* bulet_Speed, ForceMode2D.Impulse);
            }


        



    }


}
