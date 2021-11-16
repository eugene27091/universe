using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Doublsb.Dialog;
using UnityEngine.SceneManagement;
public class contract1_correct : MonoBehaviour
{
    [SerializeField] GameObject fadeIn;
    [SerializeField] GameObject fadeOut;
    [SerializeField] GameObject panel;
    public DialogManager dialogManager;
    public DialogData[] dialog;
    private int talkIdx = 0;
    private bool start = true;
    void Start()
    {
        Cursor.visible = false;
        fadeIn.GetComponent<FadeControl>().FadeIn(0.5f);
        dialog = new DialogData[4];

        dialog[0] = new DialogData("잠깐만요! 수수료가 왜 이래요? 좀 비싼거 같은데", "플레이어");
        dialog[1] = new DialogData("보증금 1000만원 + 월세55만*100 = 6500만.", "플레이어");
        dialog[2] = new DialogData("계약금 6500만 * 수수료율0.4% = 26만원 아니에요?", "플레이어");
        dialog[3] = new DialogData("아이고 내가 실수했네. 미안해요", "중개인");

    }
    void goToCorrectEnding()
    {
        Cursor.visible = true;
        SceneManager.LoadScene("클린빌라_김근육_정답엔딩");
    }
    void end()
    {
        fadeOut.GetComponent<FadeControl>().FadeOut(1f, 255f);
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
                case 2:
                    dialogManager.Show(dialog[talkIdx++]);
                    break;
                case 3:
                    
                    dialogManager.Show(dialog[talkIdx++]);
                    Invoke("end", 2f);
                    Invoke("goToCorrectEnding", 3f);
                    break;
            }
        }
    }
}
