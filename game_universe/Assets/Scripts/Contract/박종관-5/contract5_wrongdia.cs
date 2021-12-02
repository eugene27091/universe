using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Doublsb.Dialog;
using UnityEngine.SceneManagement;
public class contract5_wrongdia : MonoBehaviour
{
    [SerializeField] GameObject fadeIn;
    [SerializeField] GameObject fadeout;
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

        dialog[0] = new DialogData("문제 없는 것 같아요. 최종 계약하겠습니다.", "박관종");
        dialog[1] = new DialogData("네 잘가요 ~ ㅎㅎ", "중개인");

    }
    void goToWrongEnding()
    {
        Cursor.visible = true;
        SceneManager.LoadScene("깡통전세엔딩");
    }

    void end()
    {
        fadeout.GetComponent<FadeControl>().FadeOut(1f, 255f);
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
                    dialogManager.Show(dialog[talkIdx++]);
                    Invoke("end", 1f);
                    Invoke("goToWrongEnding", 3f);
                    break;
            }
        }
    }
}

