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

        dialog[0] = new DialogData("��񸸿�! �����ᰡ �� �̷���? �� ��Ѱ� ������", "�÷��̾�");
        dialog[1] = new DialogData("������ 1000���� + ����55��*100 = 6500��.", "�÷��̾�");
        dialog[2] = new DialogData("���� 6500�� * ��������0.4% = 26���� �ƴϿ���?", "�÷��̾�");
        dialog[3] = new DialogData("���̰� ���� �Ǽ��߳�. �̾��ؿ�", "�߰���");

    }
    void goToCorrectEnding()
    {
        Cursor.visible = true;
        SceneManager.LoadScene("Ŭ������_�����_���俣��");
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
