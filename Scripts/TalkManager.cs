
using System.Collections.Generic;
using UnityEngine;

public class TalkManager : MonoBehaviour
{
    Dictionary<int, string[]> talkData;
    private void Awake()
    {
        talkData = new Dictionary<int, string[]>();
        GenerateData();
    }

    //  ��ȭ ����
    void GenerateData()
    {
        talkData.Add(100, new string[] { "\"ħ����� Ǯ�ɼ��ΰ� ����.\"" });
        talkData.Add(110, new string[] { "\"��.. ���� ����\"", "â������ �±ǵ����� ���� ���̵��� �������� �� ���δ�." });
    }

    //  ��ȭ �ҷ�����
    public string GetTalk(int id, int talkIndex)
    {
        if (talkIndex == talkData[id].Length)
            return null;
        else
            return talkData[id][talkIndex];
    }

    public int GetLength(int id)
    {
        return talkData[id].Length;
    }
}
