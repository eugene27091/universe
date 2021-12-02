using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class life1 : MonoBehaviour
{
    [SerializeField] GameObject textBox;
    [SerializeField] Text talkText;
    [SerializeField] GameObject lifeInfo;
    [SerializeField] GameObject blocker1;
    [SerializeField] GameObject fadeOut;
    [SerializeField] GameObject select;
    [SerializeField] GameObject paper;
    [SerializeField] GameObject msg;
    public static int remain;
    private bool start = true;
    
    void showEnd()
    {
        paper.SetActive(false);
        lifeInfo.SetActive(false);
        blocker1.SetActive(true);
        msg.SetActive(false);
        // talkText.text = "계약할까?";
        // textBox.SetActive(true);
        Invoke("goToSelect", 0.5f);
    }
    void goToSelect()
    {
        fadeOut.GetComponent<FadeControl>().FadeOut(0.5f, 255f);
        SceneManager.LoadScene("클린빌라_선택");
    }
    void Start()
    {
        remain = 3;
    }


    void Update()
    {
        lifeInfo.GetComponent<Text>().text = "남은 기회: " + remain;

        if (start && Input.GetKeyDown(KeyCode.Space))
        {
            lifeInfo.SetActive(true);
            start = false;
        }

        if (remain==0 && Input.GetKeyDown(KeyCode.Space))
        {
            Invoke("showEnd", 0.5f);
        }

        
    }
}
