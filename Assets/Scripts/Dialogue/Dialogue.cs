using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour
{
    public GameObject buttonNext;
    public GameObject buttonChouse;
    public Image doctor;
    public Image character;
    public TMP_Text text;
    public CharacterDialogue characterDialogue;
    public int idDialogue;
    public int idMaxDialogue;

    void Start()
    {
        text.text = characterDialogue.dialogue[0];
        idMaxDialogue = characterDialogue.dialogue.Length - 1;
        doctor.sprite = characterDialogue.doctorSprite[0];
        character.sprite = characterDialogue.characterSprite[0];
        buttonNext.SetActive(true);
        buttonChouse.SetActive(false);
    }

    private void Update()
    {

    }

    public void NextDialogue()
    {
        if(idDialogue < idMaxDialogue)
        {
            text.text = characterDialogue.dialogue[idDialogue];
            doctor.sprite = characterDialogue.doctorSprite[idDialogue];
            character.sprite = characterDialogue.characterSprite[idDialogue];
            idDialogue++;
        }

        if (idDialogue == idMaxDialogue)
        {
            buttonNext.SetActive(false);
            buttonChouse.SetActive(true);
        }
    }

    public void Chouse(int pills)
    {
        characterDialogue.inventoryAndStats.pills += pills;
    }
}
