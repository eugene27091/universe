using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public TalkManager talkmanager;
    public GameObject curObj; //  플레이어가 조사한 오브젝트
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

        //  다른 버튼 터치 막기 
        blocker.SetActive(true);
        // 대화창 표시
        talkText.text = sentence;
        isAction = true;
        talkIndex++;
    }

    private void Update()
    {
        //  스페이스바나 버튼 클릭해서 대사 넘기기
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
