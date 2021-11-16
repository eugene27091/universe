using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Doublsb.Dialog;
using UnityEngine.SceneManagement;

public class contract5_Correct1 : MonoBehaviour
{
    [SerializeField] GameObject Audio;
    [SerializeField] GameObject Printer;
    public DialogManager dialogManager;
    [SerializeField] GameObject fadeOut;
    [SerializeField] GameObject fadeOut2;
    [SerializeField] Image panel;
    private ShakeCamera camera;
    public DialogData[] dialog;
    private int talkIdx = 0;
    private bool start = true;

    void Start()
    {
        Cursor.visible = false;
        camera = GameObject.Find("Main Camera").GetComponent<ShakeCamera>();
        dialog = new DialogData[10];

        dialog[0] = new DialogData("흠 등기부등본이랑 모두 보았는데...", "박종관");
        dialog[1] = new DialogData("수상한 부분이 있어 ", "플레이어");
        dialog[2] = new DialogData("등기부등본에서 확인했던 근저당권 대출 받은 금액은 5천만원 ", "플레이어");
        dialog[3] = new DialogData("계약서에 명시되어 있는 전세보증금은 2억", "플레이어");
        dialog[4] = new DialogData("국토교통부 부동산공시가격 홈페이지에서 알아본 현 주택 시가는 ", "플레이어");
        dialog[5] = new DialogData("3억.", "플레이어");
        dialog[6] = new DialogData("그렇다면 .. 근저당권과 전세보증금의 합이 2억 5천만원", "플레이어");
        dialog[7] = new DialogData("주택 시가의 80%가 2억 4천이니까... 80%를 넘는데 ", "플레이어");
        dialog[8] = new DialogData("곰곰히 생각해보니까 이거 완전 깡통전세잖아 ??!??!?!?!", "플레이어");
        dialog[9] = new DialogData("죄송한데 저 여기 계약 못하겠어요.", "플레이어");
    }

    private void fadeout2()
    {
        fadeOut2.GetComponent<FadeControl>().FadeOut(0.5f, 255f);
    }


    void show()
    {
        panel.GetComponent<Image>().color = new Color(0, 0, 0, 0);
        Printer.SetActive(true);
        dialogManager.Show(dialog[talkIdx++]);
    }

    void match()
    {
        Cursor.visible = true;
        SceneManager.LoadScene("매칭 씬");
    }

    void Update()
    {
        if (start)
        {
            dialogManager.Show(dialog[talkIdx++]);
            start = false;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            switch (talkIdx)
            {
                default:
                    dialogManager.Show(dialog[talkIdx++]);
                    break;
                case 9:
                    dialogManager.Show(dialog[talkIdx++]);
                    Invoke("fadeout2", 2f);
                    Invoke("match", 3f);
                    break;
                    
            }
        }
    }
}
