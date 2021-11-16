using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeSceneFive : MonoBehaviour
{
    public void computer()
    {
        SceneManager.LoadScene("computer");
    }

    public void print()
    {
        SceneManager.LoadScene("등기부등본");
    }
    public void seeprint()
    {
        SceneManager.LoadScene("박종관_등기부등본");
    }
    public void page1()
    {
        SceneManager.LoadScene("박종관_계약서");
    }
    public void correctend_5()
    {
        SceneManager.LoadScene("박종관_정답대화");
    } 
    public void wrongend_5()
    {
        SceneManager.LoadScene("박종관_오답대화");
    }
    public void imageend_5()
    {
        SceneManager.LoadScene("깡통전세엔딩");
    }
}
