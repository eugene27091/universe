using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Doublsb.Dialog;
using UnityEngine.SceneManagement;

public class StoryScene : MonoBehaviour
{
    [SerializeField] GameObject fadeIn;
    [SerializeField] GameObject fadeOut;
    [SerializeField] GameObject panel;
    [SerializeField] GameObject story1;
    [SerializeField] GameObject story2;
    [SerializeField] GameObject story2_Title;
    [SerializeField] GameObject story3;
    public DialogManager dialogManager;
    public DialogData[] dialog;
    private int talkIdx = 0;
    private bool start = true;

    void gameStart()
    {
        Cursor.visible = true;
        SceneManager.LoadScene("Scene1- 메일함 첫화면");
    }
    void Start()
    {
        Cursor.visible = false;
        fadeIn.GetComponent<FadeControl>().FadeIn(0.5f);

        dialog = new DialogData[5];

        dialog[0] = new DialogData("내 이름은 " + nickname.name, "투명");
        dialog[1] = new DialogData("2n살이지만 자취경력 15년이지", "투명");
        dialog[2] = new DialogData("오만 상황을 다 겪어봐서 이제 눈빛만 봐도 사기꾼 감별이 가능하다. ", "투명");
        dialog[3] = new DialogData("이 능력으로 용돈벌이 겸 정의구현을 위해 며칠전 커뮤니티에 글을 올렸다.", "투명");
        dialog[4] = new DialogData("글 올린지 꽤 지났는데... 메일 왔나 확인해볼까?", "투명");
    }

    void Update()
    {
        if (start && panel.GetComponent<Image>().color.a == 0f)
        {
            dialogManager.Show(dialog[talkIdx++]);
            start = false;
        }


        if (Input.GetKeyDown(KeyCode.Space))
        {
            switch (talkIdx)
            {
                case 1:
                    dialogManager.Show(dialog[talkIdx++]);
                    story1.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 255);
                    break;
                case 2:
                    story1.SetActive(false);
                    story2_Title.SetActive(true);
                    story2.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 255);
                    dialogManager.Show(dialog[talkIdx++]);
                    break;
                case 3:
                    story2.SetActive(false);
                    story3.SetActive(true);
                    dialogManager.Show(dialog[talkIdx++]);
                    break;
                case 4:
                    dialogManager.Show(dialog[talkIdx++]);
                    break;
                case 5:
                    fadeOut.GetComponent<FadeControl>().FadeOut(0.7f, 255f);
                    Invoke("gameStart", 0.7f);
                    break;

            }
        }

    }
}
