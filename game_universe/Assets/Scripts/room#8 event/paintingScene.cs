using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// 8번 그림 치우는 씬
public class paintingScene : MonoBehaviour
{
    private GameObject fade;
    private GameObject dialogue;
    private ShakeCamera camera;
    private bool isEnd = false;
    public AudioSource audiosource;

    private void exit()
    {
        dialogue.SetActive(true);
        GameObject text = GameObject.Find("Text");
        Text sentence = text.GetComponent<Text>();
        audiosource.Play();
        camera.VibrateForTime(0.5f);
        sentence.text = "으아아아악!!!!!!!!!!!!!!!!! 이게 뭐야!?!!!!!!!!!!???!!!!???";
    }

    public void changeScene()
    {
        SceneManager.LoadScene("outside_8번");
    }

    public void fadeout()
    {
        Debug.Log("fade out");
        fade = GameObject.Find("FadeControl2");
        fade.GetComponent<FadeControl>().FadeOut(0.7f, 255);
     }
    private void Start()
    {
        Cursor.visible = false;
        fade = GameObject.Find("FadeControl1");
        dialogue = GameObject.Find("TextBox");
        camera = GameObject.Find("Main Camera").GetComponent<ShakeCamera>();
    }

    void Update()
    {
        if (!isEnd)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                dialogue.SetActive(false);
                fade.GetComponent<FadeControl>().FadeIn(1f);
                Invoke("exit", 0.5f);
                Invoke("fadeout", 2.5f);
                Invoke("changeScene", 3.2f);
                isEnd = true;
            }
        }
    }
}
