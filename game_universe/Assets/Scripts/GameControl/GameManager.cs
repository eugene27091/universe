
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] TalkManager talkmanager;
    [SerializeField] GameObject blocker;
    [SerializeField] GameObject talkPanel;
    [SerializeField] Text talkText;
    [SerializeField] GameObject move1;
    [SerializeField] GameObject move2;
    [SerializeField] GameObject move3;

    private bool isAction = false;
    private int talkIndex = 0;
    private GameObject curObj;

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

        if (isAction)
        {
            // 버튼 안보이게
            if (move1 != null) move1.SetActive(false);
            if (move2 != null) move2.SetActive(false);
            if (move3 != null) move3.SetActive(false);

            //  스페이스바나 버튼 클릭해서 대사 넘기기
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
                    if (move1 != null) move1.SetActive(true);
                    if (move2 != null) move2.SetActive(true);
                    if (move3 != null) move3.SetActive(true);
                }

                talkPanel.SetActive(isAction);
            }
        }


    }
}

