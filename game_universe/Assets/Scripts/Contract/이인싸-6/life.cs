using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class life : MonoBehaviour
{
    [SerializeField] GameObject textBox;
    [SerializeField] Text talkText;
    [SerializeField] GameObject lifeInfo;
    [SerializeField] GameObject blocker1;
    [SerializeField] GameObject fadeOut;
    public static int remain;
    private bool start = true;
    
    void showEnd()
    {
        blocker1.SetActive(true);
        talkText.text = "문제없다 계약하자";
        textBox.SetActive(true);
        Invoke("fadeout", 0.6f);
    }
    void fadeout()
    {
        fadeOut.GetComponent<FadeControl>().FadeOut(0.6f, 255f);
        Invoke("change", 0.6f);
    }

    void change()
    {
        SceneManager.LoadScene("6_이인싸_입금");
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
