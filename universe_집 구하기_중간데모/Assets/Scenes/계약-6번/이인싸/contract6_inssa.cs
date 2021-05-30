using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Doublsb.Dialog;
using UnityEngine.SceneManagement;

public class contract6_inssa : MonoBehaviour
{
    [SerializeField] GameObject textBox;
    [SerializeField] GameObject fadeControl;
    [SerializeField] GameObject panel;
    [SerializeField] GameObject msg;
    [SerializeField] GameObject btn1;
    // [SerializeField] GameObject select;
    [SerializeField] GameObject paper;
    public DialogManager dialogManager;
    public DialogData dialog;
    private int talkIdx = 0;
    private bool start = true;
    private bool isAction = true;

    void Start()
    {
        fadeControl.GetComponent<FadeControl>().FadeIn(0.5f);
        dialog = new DialogData("계약서 쓸게요", "플레이어");
        
    }

    // Update is called once per frame
    void Update()
    {
        if (start && panel.GetComponent<Image>().color.a == 0f)
        {
            textBox.SetActive(true);
            dialogManager.Show(dialog);
            start = false;
        }

        if (isAction&&Input.GetKeyDown(KeyCode.Space))
        {
            textBox.SetActive(false);
            msg.SetActive(true);
            paper.SetActive(true);
            btn1.SetActive(true);
            isAction = false;
        }
    }
}
