using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InventoryAndStats : MonoBehaviour
{
    public int hp;
    public TMP_Text hpText;
    public int pills;
    public TMP_Text pillsText;

    void Update()
    {
        hpText.text = "HP: " + hp;
    }
}
