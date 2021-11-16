using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Doublsb.Dialog;
using UnityEngine.SceneManagement;

public class contract6_wrong : MonoBehaviour
{
    [SerializeField] GameObject Audio;
    [SerializeField] GameObject Printer;
    public DialogManager dialogManager;
    [SerializeField] GameObject fadeOut;
    public DialogData[] dialog;
    private int talkIdx = 0;
    private bool start = true;

    void Start()
    {
        Cursor.visible = false;
        dialog = new DialogData[5];

        dialog[0] = new DialogData("(가족이라니까 별 일 없겠지.)", "플레이어");
        dialog[1] = new DialogData("네~ 그럼 입금할게요", "이인싸");
        dialog[2] = new DialogData("/wait:0.4/입금했어요 ", "이인싸");
        dialog[3] = new DialogData("네 확인했습니다 ㅎㅎ ", "대리인");
        dialog[4] = new DialogData("이제 도장만 찍으면 되겠네요", "중개인");
    }

    private void fadeout()
    {
        fadeOut.GetComponent<FadeControl>().FadeOut(1f, 255f);
        Invoke("showEnd", 3f);
    }

    void showEnd()
    {
        Cursor.visible = true;
        SceneManager.LoadScene("6_이인싸_엔딩");
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
            dialogManager.Show(dialog[talkIdx++]);
            if (talkIdx == 5)
            {
                Invoke("fadeout", 2f);
            }
        }
    }
}
