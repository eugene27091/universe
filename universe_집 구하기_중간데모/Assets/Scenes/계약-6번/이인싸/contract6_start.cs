using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Doublsb.Dialog;
using UnityEngine.SceneManagement;
public class contract6_start : MonoBehaviour
{
    [SerializeField] GameObject fadeIn;
    [SerializeField] GameObject panel;
    [SerializeField] GameObject select;
    public DialogManager dialogManager;
    public DialogData[] dialog;
    private int talkIdx = 0;
    private bool start = true;
    void Start()
    {
        Cursor.visible = false;
        fadeIn.GetComponent<FadeControl>().FadeIn(0.5f);
        dialog = new DialogData[6];

        dialog[0] = new DialogData("프라임원룸으로 결정하셨다고요? 잘 골랐네~", "중개인");
        dialog[1] = new DialogData("여기 앉아서 잠깐만 기다려요. 집주인한테 연락할게", "중개인");
        dialog[2] = new DialogData("안녕하세요 ㅎㅎ", "대리인");
        dialog[3] = new DialogData("집주인 남편되는 사람입니다. 부인이 요즘 바빠서 저를 대신 보냈어요.", "대리인");
        dialog[4] = new DialogData("(남편이 대신 왔군..확인할게 많아지겠는걸)", "플레이어");
        dialog[5] = new DialogData("뭐부터 볼까?", "플레이어");
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
                case 1: case 2:  case 3: case 4:
                    dialogManager.Show(dialog[talkIdx++]);
                    break;
                case 5:
                    Cursor.visible = true;
                    dialogManager.Show(dialog[talkIdx++]);
                    select.SetActive(true);
                    break;
            }
        }
    }
}
