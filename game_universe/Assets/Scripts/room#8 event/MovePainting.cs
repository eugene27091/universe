using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovePainting : MonoBehaviour
{
    [SerializeField] Text talk;
    [SerializeField] GameObject talkPanel;
    [SerializeField] GameObject yesBtn1;
    [SerializeField] GameObject yesBtn2;
    [SerializeField] GameObject block;
    private bool isAction = false;

    void Update()
    {
        if (!isAction)
        {
            string target = "한 번 치워볼까?";
            if (talk.text == target && talkPanel.activeSelf == false && yesBtn1.activeSelf == false)
            {
                Debug.Log("버튼 활성화");
                block.SetActive(true);
                yesBtn1.SetActive(true);
                yesBtn2.SetActive(true);

                isAction = true;
            }
        }
    }
}
