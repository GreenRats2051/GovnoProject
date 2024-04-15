using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Speach : MonoBehaviour
{
    public Transform TransformA;
    public Transform TransformS;

    public AudioSource SourceOfTiping;
    public AudioClip player;

    private AudioClip TipingText;

    public AudioClip Medic;

    public Shangescen Shangescen;
    public Sprite SpriteSpeak;
    public Sprite SpriteAnswer;
    public Image BackG;
    public List<Button> buttons = new List<Button>();
    bool next = true;
    bool ChangeAspect = true;
    public TextMeshProUGUI textMeshProUGUI;
    public string[][] AnsversMasEng = new string[][] { Answers1Eng, Answers2Eng, Answers3Eng };
    
    public static string[] Terapia1Eng = new string[] { "- good afternoon, I already thought that you would not come. How are you feeling today?",
"-Are you sure about that? After all, rehabilitation is not an easy process...",
"- I am absolutely sure",
"- that's great, but I'll still need to run some simple tests to determine your sanity.",
"- No injections today?",
"- No, we are still afraid to give you medicines through injections. There may be a risk of symptoms returning",
"- Maybe..",
"- Therefore, for now you can be free, I will write you a prescription for additional medications, they will not harm you." };
    static string[] Answers1Eng = new string[] { "- much better" };

    public static string[] Terapia2Eng = new string[] {"- Hello. I see that the medicines are working for your benefit, even your gaze is not so lost",
"- Probably yes, i feel better",
"- But you still seem exhausted, how would you describe your condition in recent days?",
"- I'll write down your answer... do not forget that your every response will affect your treatment",
"- I've learned that well.",
"- That's great. I'm watching your movements and I want to say that you're in much better control of yourself now. This is good news",
"- Pf, I'm practicing in front of the mirror how to sit in front of you)",
"- I hope this is just a joke?",
"- Of course it's a joke",
"- I'll leave you the same dose of medicine for now. I'll be waiting for you at the next reception"
};

    static string[] Answers2Eng = new string[] { " - I feel only small feats, and sometimes I feel like before",
 "- as if nothing had happened, I am completely healthy",
 "- maybe these empty words are enough? I'm already tired of all this, it's time to realize that everything is fine with me." };


    public static string[] Terapia3Eng = new string[] { "- Of course you are blossoming before our eyes! I'm glad to see that you look happier.",
"- Of course, I even feel a certain surge of strength..",
"- I want to ask you a slightly unusual question. What can you say about your future? What will you do after recovery?","- Thanks for the answer. I can say that you still look better physically. I think I'll reduce the dose of your medications.",
"- It's not bad, sometimes they cause worse effects than drugs.",
"- You've never talked about it, so it's definitely worth reducing their number. I'll give you a new recipe." };

    static string[] Answers3Eng = new string[] { "- I will return home and finally be able to be alone with myself", "- I will return to work, start a family, children, and live a completely ordinary life",
"- do I have a future after this?" };
    public string[][] Terapias = new string[][] { Terapia1Eng, Terapia2Eng, Terapia3Eng };



    private void Update()
    {
        if ((Input.GetKeyUp(KeyCode.Mouse0) || Input.GetKeyUp(KeyCode.E)) && next)
        {
            if(GameManager.pos==Terapias[GameManager.posTerapia].Length-1)
            {
                Shangescen.Onclick();
            }
            else
            {
                OnClick();
            }


        }


    }
    public void OnClick()
    {

        textMeshProUGUI.text = null;
        if (GameManager.pos == 0)
        {
            showButton();
           
        }
        else
        {
            GameManager.pos++;
            StartCoroutine(ShowText());
        }

    }

    public void showButton()
    {

        switch (AnsversMasEng[GameManager.posAnsvers].Length)
        {
            case 1:
                buttons[0].gameObject.SetActive(!buttons[0].gameObject.activeSelf);
                buttons[0].GetComponentInChildren<TextMeshProUGUI>().text = AnsversMasEng[GameManager.posAnsvers][0];
                break;
            case 2:
                buttons[0].gameObject.SetActive(!buttons[0].gameObject.activeSelf);
                buttons[1].gameObject.SetActive(!buttons[1].gameObject.activeSelf);
                buttons[0].GetComponentInChildren<TextMeshProUGUI>().text = AnsversMasEng[GameManager.posAnsvers][0];
                buttons[1].GetComponentInChildren<TextMeshProUGUI>().text = AnsversMasEng[GameManager.posAnsvers][1];
                break;
            case 3:
                buttons[0].gameObject.SetActive(!buttons[0].gameObject.activeSelf);
                buttons[1].gameObject.SetActive(!buttons[1].gameObject.activeSelf);
                buttons[2].gameObject.SetActive(!buttons[2].gameObject.activeSelf);
                buttons[0].GetComponentInChildren<TextMeshProUGUI>().text = AnsversMasEng[GameManager.posAnsvers][0];
                buttons[1].GetComponentInChildren<TextMeshProUGUI>().text = AnsversMasEng[GameManager.posAnsvers][1];
                buttons[2].GetComponentInChildren<TextMeshProUGUI>().text = AnsversMasEng[GameManager.posAnsvers][2];
                break;


        }


    }

    public IEnumerator ShowText()
    {
        next = false;
        if (ChangeAspect)
        {
            BackG.sprite = SpriteSpeak;
            ChangeAspect = false;
            textMeshProUGUI.gameObject.transform.position = TransformS.position;
            TipingText = Medic;
        }
        else
        {
            BackG.sprite = SpriteAnswer;
            ChangeAspect = true;
            textMeshProUGUI.gameObject.transform.position = TransformA.position;
            TipingText = player;
        }
        for (int i = 0; i < Terapias[GameManager.posTerapia][GameManager.pos].Length; i++)
        {
            textMeshProUGUI.text += Terapias[GameManager.posTerapia][GameManager.pos][i];
            SourceOfTiping.PlayOneShot(TipingText);
            yield return new WaitForSeconds(0.07f);
        }
        next = true;
        //textMeshProUGUI.text += Terapia1Eng[GameManager.pos];
        //yield return null;
    }



}
