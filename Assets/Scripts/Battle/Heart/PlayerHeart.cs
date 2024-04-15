using System.Collections;
using System.Collections.Generic;
using UnityEngine;
<<<<<<< Updated upstream
using UnityEngine.SceneManagement;
=======
<<<<<<< HEAD
using UnityEngine.SceneManagement;
=======
>>>>>>> 833d43396f565e5639f05fa1773f916b030055a7
>>>>>>> Stashed changes
using UnityEngine.UI;

public class PlayerHeart : MonoBehaviour
{
    int HeartPoints = 7;
<<<<<<< Updated upstream
=======
<<<<<<< HEAD
>>>>>>> Stashed changes
    public List<Image> Hearts = new List<Image>();
    public string nameScene;

    private void FixedUpdate()
    {
        if(HeartPoints <= 0)
        {
            SceneManager.LoadScene(nameScene);
        }
    }

<<<<<<< Updated upstream
=======
=======
    
    public List<Image> Hearts = new List<Image>();
>>>>>>> 833d43396f565e5639f05fa1773f916b030055a7
>>>>>>> Stashed changes
    public void OnHeartLost()
    {
        Hearts[HeartPoints].fillAmount -= 0.5f;
        if (Hearts[HeartPoints].fillAmount == 0)
        {
            HeartPoints -= 1;
        }
    }

}
