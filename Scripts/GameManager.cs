using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public TalkManager talkmanager;
    public GameObject curObj; //  �÷��̾ ������ ������Ʈ
    public GameObject talkPanel;

    public GameObject blocker;
    public bool isAction = false;
    public int talkIndex = 0;
    public Text talkText;
    

    public void Action(GameObject scanObj)
    {
        isAction = true;
        curObj = scanObj;
        ObjData objData = curObj.GetComponent<ObjData>();
        nextDialogue(objData.id);
        
        talkPanel.SetActive(isAction);
    }

    void nextDialogue(int id)
    {
        string sentence = talkmanager.GetTalk(id, talkIndex);

        //  �ٸ� ��ư ��ġ ���� 
        blocker.SetActive(true);
        // ��ȭâ ǥ��
        talkText.text = sentence;
        isAction = true;
        talkIndex++;
    }

    private void Update()
    {
        //  �����̽��ٳ� ��ư Ŭ���ؼ� ��� �ѱ��
        if (isAction)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                ObjData objData = curObj.GetComponent<ObjData>();
                if (talkIndex < talkmanager.GetLength(objData.id))
                {
                    nextDialogue(objData.id);
                }
                else
                {
                    talkIndex = 0;
                    isAction = false;
                    blocker.SetActive(false);
                }

                talkPanel.SetActive(isAction);
            }
        }

            
    }
}
