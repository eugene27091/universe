using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeScene_1 : MonoBehaviour
{
    public void ch1_warrant()
    {
        SceneManager.LoadScene("클린빌라_김근육_계약서");
    }
    public void goToCorrectDialogue(){
        SceneManager.LoadScene("클린빌라_김근육_정답대화");
    }
    public void goToWrongDialogue(){
        SceneManager.LoadScene("클린빌라_김근육_오답대화");
    }

}
