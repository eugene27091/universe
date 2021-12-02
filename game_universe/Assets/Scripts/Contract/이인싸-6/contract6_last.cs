using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Doublsb.Dialog;
using UnityEngine.SceneManagement;

public class contract6_last: MonoBehaviour
{
    [SerializeField] GameObject select;
    [SerializeField] GameObject account;
    public DialogManager dialogManager;
    public DialogData[] dialog;
    private int talkIdx = 0;
    private bool start = true;

    void Start()
    {
        Cursor.visible = false;
        dialog = new DialogData[3];

        dialog[0] = new DialogData("그러면 계약금은 이쪽으로 입금해주시면 됩니다", "대리인");
        dialog[1] = new DialogData("대리인 계좌번호군", "플레이어");
        dialog[2] = new DialogData("어떻게 할까?", "플레이어");
    }

    // Update is called once per frame
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
                    account.SetActive(true);
                    dialogManager.Show(dialog[talkIdx++]);
                    break;
                case 2:
                    Cursor.visible = true;
                    account.SetActive(false);
                    dialogManager.Show(dialog[talkIdx++]);
                    select.SetActive(true);
                    break;
            }
        }
    }
}
