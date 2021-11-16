using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class nickname : MonoBehaviour
{

    public static string name;
    [SerializeField] InputField input;
    [SerializeField] Text check;
    [SerializeField] Image panel;
    [SerializeField] Button yes;
    [SerializeField] Button no;

    public void onClick()
    {
        name = input.text;
        if (name == "")
        {
            check.text = "이름은 한글자 이상 입력해야 합니다.";
            panel.gameObject.SetActive(true);
            no.gameObject.SetActive(true);
        }
        else{
            check.text = "\"" + name + "\"" + "으로 하시겠습니까?";
            panel.gameObject.SetActive(true);
            yes.gameObject.SetActive(true);
            no.gameObject.SetActive(true);
        } 
    }
    void Start()
    {
        
    }

 
    void Update()
    {
        
    }
}
