using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DialogueData", menuName = "Dialogue/Character")]
public class CharacterDialogue : ScriptableObject
{
    public Sprite[] friendsSprite;
    public Sprite[] characterSprite;
    public string[] dialogue;
}
