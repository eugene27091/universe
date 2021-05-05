using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickButton : MonoBehaviour
{
    public void SceneChange()
    {
        SceneManager.LoadScene("Scene1- 메일함 첫화면");
    }
    public void SceneChange2()
    {
        SceneManager.LoadScene("Scene2- 김근육");
    }
    public void SceneChange3()
    {
        SceneManager.LoadScene("Scene3- 이인싸");
    }
    public void SceneChange4()
    {
        SceneManager.LoadScene("Scene4- 박종관");
    }
}
