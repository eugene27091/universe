
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

        //  �ٸ� ��ư ��ġ ���� 
        blocker.SetActive(true);
        // ��ȭâ ǥ��
        talkText.text = sentence;
        isAction = true;
        talkIndex++;
    }

    private void Update()
    {

        if (isAction)
        {
            // ��ư �Ⱥ��̰�
            if (move1 != null) move1.SetActive(false);
            if (move2 != null) move2.SetActive(false);
            if (move3 != null) move3.SetActive(false);

            //  �����̽��ٳ� ��ư Ŭ���ؼ� ��� �ѱ��
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

