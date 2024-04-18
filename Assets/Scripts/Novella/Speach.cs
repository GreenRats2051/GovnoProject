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
    public GameObject GameObject;
    private AudioClip TipingText;

    public AudioClip Medic;

    public Shangescen Shangescen;
    public Sprite SpriteSpeak;
    public Sprite SpriteAnswer;
    public Image BackG;
    public List<Button> buttons = new List<Button>();
    bool next = true;
    public static bool nextforbutton = true;
    bool ChangeAspect = true;
    public TextMeshProUGUI textMeshProUGUI;
    Coroutine Soundtiping;
    Coroutine Text;



    public static string[] Terapia1Rus = new string[] { "-добрый день, я уже думал, что вы не придете. Как ваше самочувствие сегодня?",
        "вы в этом уверены? Все таки реабилитация это непростой процесс...","-абсолютно уверен"
        ,"-Замечтательно, но мне все равно нужно будет провести несколько простых тестов для определения вашей вменяемости"
        ,"-Сегодня без уколов?","-Без, мы пока опасаемся давать вам препараты через инъекции. Может быть риск возвращения симптомов",
        "-Может быть..","-Поэтому пока что вы можете быть свободны, я выпишу вам рецепт на дополнительные лекарства, они не навредят вам",};
    static string[] Answers1Rus = new string[] { "- намного лучше" };

    public static string[] Terapia2Rus = new string[] {
        "-и снова здравствуйте. Вижу, что лекарства действуют вам на пользу, даже ваш взгляд не такой потерянный",
        "-кажется да, все не так плохо","-Но вы все еще кажитесь  истощенным, как бы вы описали свое состояние в последние дни?","-я запишу ваш ответ... не забывайте, что каждый ваш ответ будет влиять на ваше лечение"
        ,"-Я это хорошо усвоил"
        ,"-Это отлично. Я слежу за вашими телодвижениями и хочу сказать, что вы теперь намного лучше контролируете себя. Это не может не радовать"
        ,"-Пф, я перед зеркалом тренируюсь как сесть перед вами)","-Надеюсь это лишь шутка?","-Конечно же шутка","-Пока что оставлю вам прежнюю дозу лекарств. Жду вас на следующем приеме"};

    static string[] Answers2Rus = new string[] { "1.(Правда) - я ощущаю только небольшие сподвиги, а иногда чувствую себя как раньше" ,
        "2.(Лож) - как будто и ничего и не было, я полностью здоров," ,
        "3.(Средне) - а может хватит этих пустых слов? Я уже устал от всего этого, пора уже понять, что со мной все нормально" };
    public static string[] Terapia3Rus = new string[] { "-Безусловно вы расцветаете на глазах! Рад видеть, что вы выглядите счастливее," ,
        "-Конечно, я даже чувствую некоторый прилив сил..," ,
        "-Я хочу задать вам немного необычный вопрос. Что вы можете сказать насчет вашего будущего? Чем вы займетесь после восстановления?","-Спасибо за ответ. Могу сказать, что физически вы все равно выглядите лучше. Пожалуй, я снижу дозу ваших препаратов," ,
        "-Это неплохо, иногда они вызывают эффект похуже наркотиков," ,
        "-Вы никогда не говорили об этом, значит точно стоит уменьшить их количество. Я дам вам новый рецепт" };

    static string[] Answers3Rus = new string[] { "1.(Правда) - вернусь домой и наконец смогу остаться наедине с собой," ,
        "2.(Ложь) - вернусь на работу, заведу семью, детей, буду совершенно обыкновенно жить," ,
        "3.(Средне) - после такого у меня есть будущее?" };







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
    public static string[][] TerapiasEng = new string[][] { Terapia1Eng, Terapia2Eng, Terapia3Eng };

    public static string[][] AnsversMasEng = new string[][] { Answers1Eng, Answers2Eng, Answers3Eng };
    public static string[][] TerapiasRus = new string[][] { Terapia1Rus, Terapia2Rus, Terapia3Rus };
    public static string[][] AnsversMasRus = new string[][] { Answers1Rus, Answers2Rus, Answers3Rus };
    public string[][][] TerapiasLanguage = new string[][][] { TerapiasEng, TerapiasRus };
    public string[][][] AnsversMasLanguage = new string[][][] { AnsversMasEng, AnsversMasRus };

    private void Update()
    {
        try
        {
            if ((Input.GetKeyUp(KeyCode.Mouse0) || Input.GetKeyUp(KeyCode.E)) && next&& nextforbutton)
            {

                if (GameManager.pos == TerapiasLanguage[GameManager.Language][GameManager.posTerapia].Length - 1)
                {
                    GameObject.SetActive(true);
                }
                else
                {
                    OnClick();
                }


            }

        }
        catch (IndexOutOfRangeException w)
        {
            GameObject.SetActive(true);
        }



    }
    public void OnClick()
    {

        textMeshProUGUI.text = null;


        if (GameManager.pos == 0 && GameManager.posTerapia == 0)
        {
            showButton();

        }
        else if (GameManager.pos == 2 && GameManager.posTerapia == 1)
        {
            showButton();

        }
        else if (GameManager.pos == 2 && GameManager.posTerapia == 2)
        {
            showButton();

        }
        else
        {
            GameManager.pos++;
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
            StartCoroutine(ShowText());

        }

    }

    public void showButton()
    {

        switch (AnsversMasLanguage[GameManager.Language][GameManager.posAnsvers].Length)
        {
            case 1:
                buttons[0].gameObject.SetActive(!buttons[0].gameObject.activeSelf);
                buttons[0].GetComponentInChildren<TextMeshProUGUI>().text = AnsversMasLanguage[GameManager.Language][GameManager.posAnsvers][0];
                break;
            case 2:
                buttons[0].gameObject.SetActive(!buttons[0].gameObject.activeSelf);
                buttons[1].gameObject.SetActive(!buttons[1].gameObject.activeSelf);
                buttons[0].GetComponentInChildren<TextMeshProUGUI>().text = AnsversMasLanguage[GameManager.Language][GameManager.posAnsvers][0];
                buttons[1].GetComponentInChildren<TextMeshProUGUI>().text = AnsversMasLanguage[GameManager.Language][GameManager.posAnsvers][1];
                break;
            case 3:
                buttons[0].gameObject.SetActive(!buttons[0].gameObject.activeSelf);
                buttons[1].gameObject.SetActive(!buttons[1].gameObject.activeSelf);
                buttons[2].gameObject.SetActive(!buttons[2].gameObject.activeSelf);
                buttons[0].GetComponentInChildren<TextMeshProUGUI>().text = AnsversMasLanguage[GameManager.Language][GameManager.posAnsvers][0];
                buttons[1].GetComponentInChildren<TextMeshProUGUI>().text = AnsversMasLanguage[GameManager.Language][GameManager.posAnsvers][1];
                buttons[2].GetComponentInChildren<TextMeshProUGUI>().text = AnsversMasLanguage[GameManager.Language][GameManager.posAnsvers][2];
                break;


        }
        nextforbutton = false;

    }

    public IEnumerator ShowText()
    {
        next = false;
        //StartCoroutine(soundsplay());
        for (int i = 0; i < TerapiasLanguage[GameManager.Language][GameManager.posTerapia][GameManager.pos].Length; i++)
        {
            textMeshProUGUI.text += TerapiasLanguage[GameManager.Language][GameManager.posTerapia][GameManager.pos][i];
            if (i % 4 == 0)
            {
                SourceOfTiping.PlayOneShot(TipingText);
            }

            yield return new WaitForSeconds(0.02f);
        }

        next = true;
        //textMeshProUGUI.text += Terapia1Eng[GameManager.pos];
        //yield return null;
    }
    //IEnumerator soundsplay()
    //{
    //    for (int i = 0; i < TerapiasLanguage[GameManager.Language][GameManager.posTerapia][GameManager.pos].Length / 2; i++)
    //    {

    //        SourceOfTiping.PlayOneShot(TipingText);
    //        yield return new WaitForSeconds(0.04f);
    //    }
    //}


}