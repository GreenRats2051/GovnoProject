using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Switchback : MonoBehaviour
{
    public Sprite SpriteRenderer1;
    public Sprite SpriteRenderer2;
    public Sprite SpriteRenderer3;
    public Image BackGround;
    public NextLevel nextLevel;

    private void Update()
    {
        if (nextLevel.destroyedEnemy < 2)
        {
            BackGround.sprite = SpriteRenderer1;
        }
        else if(nextLevel.destroyedEnemy  == 4)
        {
            BackGround.sprite = SpriteRenderer2;
        }
        else if (nextLevel.destroyedEnemy == 6)
        {
            BackGround.sprite = SpriteRenderer3;
        }

    }
}
