using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Doublsb.Dialog;
using UnityEngine.SceneManagement;
public class contract1_wrong : MonoBehaviour
{
    [SerializeField] GameObject fadeIn;
    [SerializeField] GameObject panel;
    public DialogManager dialogManager;
    public DialogData[] dialog;
    private int talkIdx = 0;
    private bool start = true;
    void Start()
    {
        Cursor.visible = false;
        fadeIn.GetComponent<FadeControl>().FadeIn(0.5f);
        dialog = new DialogData[2];

        dialog[0] = new DialogData("문제 없네요. 최종 계약 하겠습니다.", "김근육");
        dialog[1] = new DialogData("드디어 한건 했네~ 잘가요!", "중개인");
        
    }
    void goToWrongEnding(){
        SceneManager.LoadScene("클린빌라_김근육_오답엔딩");
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
                // case 1: case 2:
                //     dialogManager.Show(dialog[talkIdx++]);
                //     break;
                case 1:
                    Cursor.visible = true;
                    dialogManager.Show(dialog[talkIdx++]);
                    fadeIn.GetComponent<FadeControl>().FadeIn(3f);
                    Invoke("goToWrongEnding", 3f);
                    break;
            }
        }
    }
}
