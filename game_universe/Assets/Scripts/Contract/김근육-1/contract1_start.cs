using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Doublsb.Dialog;
using UnityEngine.SceneManagement;
public class contract1_start : MonoBehaviour
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
        dialog = new DialogData[4];

        dialog[0] = new DialogData("클린빌라로 결정할까요? 이 가격에 이런 집 없어요 ~ ", "중개인");
        dialog[1] = new DialogData("네 계약 할게요", "김근육");
        dialog[2] = new DialogData("앉아서 잠깐만 기다려요. 집주인한테 연락할게", "중개인");
        dialog[3] = new DialogData("여기 계약서 보고 있어요", "중개인");
        
    }
    void goToWarrant(){
        SceneManager.LoadScene("클린빌라_김근육_계약서");
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
                case 1: case 2:
                    dialogManager.Show(dialog[talkIdx++]);
                    break;
                case 3:
                    Cursor.visible = true;
                    dialogManager.Show(dialog[talkIdx++]);
                    fadeIn.GetComponent<FadeControl>().FadeIn(3f);
                    Invoke("goToWarrant", 3f);
                    break;
            }
        }
    }
}
