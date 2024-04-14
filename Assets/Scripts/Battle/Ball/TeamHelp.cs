using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeamHelp : MonoBehaviour
{
    bool IsHave = true;
    public GameObject teampref;
    public Transform spawnpoint;
    private void Awake()
    {
        if (IsHave)
        {
            GameObject gameObject = Instantiate(teampref,new Vector3( spawnpoint.position.x, spawnpoint.position.y,0), spawnpoint.localRotation);
            gameObject.transform.parent = spawnpoint.transform;
            StartCoroutine(RotateObj());
        }
        
    }
    IEnumerator RotateObj()
    {
        while (IsHave)
        {
            transform.localRotation *= Quaternion.Euler(new Vector3(0, 0, 1f));
            yield return new WaitForSeconds(0.01f);
        }



    }

}
