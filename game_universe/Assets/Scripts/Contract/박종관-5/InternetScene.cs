using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InternetScene : MonoBehaviour
{
    [SerializeField] GameObject talkPanel;
    [SerializeField] Text text;
    [SerializeField] GameObject button;

    private bool isAction = false;
    public void wrongAns()
    {
        button.SetActive(false);
        text.text = "이런 주소가 있을리가 없잖아.";
        talkPanel.SetActive(true);
        text.gameObject.SetActive(true);
        isAction = true;
    }

    private void Start()
    {
        Cursor.visible = false;
    }
    // Update is called once per frame
    void Update()
    {

        if (text.text == "주소로 검색하자" && text.gameObject.activeSelf == false)
        {
            Cursor.visible = true;
            button.SetActive(true);
        }

        if (isAction)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                talkPanel.SetActive(false);
                text.gameObject.SetActive(false);
                button.SetActive(true);
                isAction = false;
            }

        }
    }
}
