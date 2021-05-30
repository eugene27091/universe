using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class startScene : MonoBehaviour
{
    [SerializeField] GameObject fadeControl;
    [SerializeField] GameObject panel;
    [SerializeField] GameObject blocker1;
    private bool once = false;

    private void Start()
    {
            Debug.Log("start 시작");
            Cursor.visible = false;
            fadeControl.GetComponent<FadeControl>().FadeIn(0.3f);
    }

    void Update()
    {
        if (!once)
        {
            if (panel.GetComponent<Image>().color.a > 0f)
            {
                Cursor.visible = false;
                blocker1.SetActive(true);
            }
            else
            {
                Cursor.visible = true;
                once = true;
                blocker1.SetActive(false);
            }
        }

    }
}
