using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartSceneFive : MonoBehaviour
{
    [SerializeField] GameObject fadeControl;
    [SerializeField] GameObject panel;
    [SerializeField] GameObject manager;

    private bool isEnd = false;

    void Start()
    {
        fadeControl.GetComponent<FadeControl>().FadeIn(0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        if (!isEnd)
        {
            if (panel != null && panel.GetComponent<Image>().color.a == 0f)
            {
                manager.GetComponent<showDialogue>().Action();
                isEnd = true;
            }
        }

    }

}
