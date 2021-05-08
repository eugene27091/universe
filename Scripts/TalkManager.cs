
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

    //  대화 저장
    void GenerateData()
    {
        talkData.Add(100, new string[] { "\"침대까지 풀옵션인가 보네.\"" });
        talkData.Add(110, new string[] { "\"와.. 전망 좋다\"", "창밖으로 태권도복을 입은 아이들이 지나가는 게 보인다." });
    }

    //  대화 불러오기
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
