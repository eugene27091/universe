using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class roomScene : MonoBehaviour
{
    float time;
    [SerializeField] Text text;
    [SerializeField] GameObject outline;

    private void Start()
    {
        Cursor.visible = false;
    }
    void Update()
    {
        if (text.text == "이제 등기부등본을 확인해볼까" && text.gameObject.activeSelf == false)
        {
            Cursor.visible = true;
            Debug.Log("버튼 활성화");
            outline.SetActive(true);
            if (time < 0.5f)
            {
                outline.GetComponent<Image>().color = new Color(1, 1, 1, 1 - time);
            }
            else
            {
                outline.GetComponent<Image>().color = new Color(1, 1, 1, time);
                if (time > 1f)
                {
                    time = 0;
                }
            }
            time += Time.deltaTime;
        }
    }
}
