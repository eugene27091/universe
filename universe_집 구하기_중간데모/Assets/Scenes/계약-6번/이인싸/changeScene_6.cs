using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeScene_6 : MonoBehaviour
{
    public void ch1_warrant()
    {
        SceneManager.LoadScene("6_이인싸_위임장");
    }

    public void ch1_contract()
    {
        SceneManager.LoadScene("6_이인싸_계약서");
    }

    public void ch1_correct()
    {
        SceneManager.LoadScene("6_이인싸_정답");
    }

    public void ch1_wrong()
    {
        SceneManager.LoadScene("6_이인싸_오답");
    }

    public void ch1_money()
    {
        SceneManager.LoadScene("6_이인싸_입금");
    }

}
