using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class oustideScene : MonoBehaviour
{
    [SerializeField] GameObject fade;
    [SerializeField] GameObject panel;
    [SerializeField] GameObject block;
    [SerializeField] GameObject textBox;
    [SerializeField] Text talk;
    [SerializeField] Button btn;
    private bool isEnd = false;

    public void showText()
    {
        fade = GameObject.Find("FadeControl2");
        fade.GetComponent<FadeControl>().FadeOut(0.2f, 169f);
        talk.text = "미친거 아니야?! 어쩐지 너무 싸더라";
        talk.gameObject.SetActive(true);
    }

    public void showBtn()
    {
        Cursor.visible = true;
        block.SetActive(true);
        btn.gameObject.SetActive(true);
    }

    private void Start()
    {
        fade.GetComponent<FadeControl>().FadeIn(0.5f);
        Cursor.visible = false;
    }

    void Update()
    {
        if (!isEnd)
        {
            if (panel.GetComponent<Image>().color.a == 0f)
            {
                showText();
                isEnd = true;
            }
        }

        if(talk.IsActive()&&talk.text == "미친거 아니야?! 어쩐지 너무 싸더라" && Input.GetKeyDown(KeyCode.Space)){
            textBox.SetActive(false);
            showBtn();
        }
    }
}
