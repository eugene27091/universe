using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Doublsb.Dialog;
using UnityEngine.SceneManagement;

public class contract6_correct : MonoBehaviour
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
        camera = GameObject.Find("Main Camera").GetComponent<ShakeCamera>();
        dialog = new DialogData[18];

        dialog[0] = new DialogData("네~그럼 입금을...", "이인싸");
        dialog[1] = new DialogData("잠깐만요! ", "플레이어");
        dialog[2] = new DialogData("분명 위임장에는 계약체결까지만 대신하신다고 쓰여 있었는데요 ", "플레이어");
        dialog[3] = new DialogData("아~그렇긴 한데 부인이 너무 바빠서 지금 입금 확인을 못할거에요 ㅎㅎ", "대리인");
        dialog[4] = new DialogData("그냥 저한테 보내셔도 괜찮아요", "대리인");
        dialog[5] = new DialogData("아무래도 이상해. 집주인한테 전화를 해봐야겠어", "플레이어");
        dialog[6] = new DialogData("여보세요?", "집주인");
        dialog[7] = new DialogData("안녕하세요 프라임원룸 집주인분 번호 맞나요?", "플레이어");
        dialog[8] = new DialogData("지금 계약하려고 하는데 확인할 사항이 있어서 연락드렸어요", "플레이어");
        dialog[9] = new DialogData("네? 프라임원룸? 거기 이미 사람 살고 있는데?", "집주인");
        dialog[10] = new DialogData("에? 지금 남편분이 대리인으로 오셔서 계약서 썼는데요", "플레이어");
        dialog[11] = new DialogData("이 인간이 진짜?!!!!!!!!!!!!!!??", "집주인");
        dialog[12] = new DialogData("미안하게 됐어요. 나도 사기꾼인줄은 몰랐네", "중개인");
        dialog[13] = new DialogData("몇년전부터 별거중이라는데", "중개인");
        dialog[14] = new DialogData("따로 연락 받은 적이 없었어요", "중개인");
        dialog[15] = new DialogData("집주인네 가족이라 괜찮을 줄 알았지", "중개인");
        dialog[16] = new DialogData("어후 심장떨려 보증금 날릴뻔 했잖아? 어떻게 모은 돈인데!", "이인싸");
        dialog[17] = new DialogData("다른 집으로 알아봐 드릴게요", "플레이어");
    }

    private void fadeout()
    {
        fadeOut.GetComponent<FadeControl>().FadeOut(0.5f, 255f);
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
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    dialogManager.Show(dialog[talkIdx++]);
                    break;
                case 6:
                    Audio.GetComponent<ChangeScene>().AudioPlay();
                    dialogManager.Show(dialog[talkIdx++]);
                    break;
                case 7: case 8: case 9:
                case 10:
                    dialogManager.Show(dialog[talkIdx++]);
                    break;
                case 11:
                    camera.VibrateForTime(0.7f);
                    dialogManager.Show(dialog[talkIdx++]);
                    Invoke("fadeout", 2f);
                    Invoke("show", 4f);
                    break;
                case 13:
                case 14:
                case 15:
                case 16:
                    dialogManager.Show(dialog[talkIdx++]);
                    break;
                case 17:     
                    dialogManager.Show(dialog[talkIdx++]);
                    Invoke("fadeout2", 2f);
                    Invoke("match", 3f);
                    break;
            }
        }
    }
}
