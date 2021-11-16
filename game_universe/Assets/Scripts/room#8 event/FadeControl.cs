using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeControl : MonoBehaviour
{
    [SerializeField] Image panel;

    bool isAction = false;
    float time = 0f;
    
    // 불투명 -> 투명
    public void FadeIn(float f_time)
    {
        StartCoroutine(CoFadeIn(f_time));
        Invoke("enabled",f_time);
    }

    public void enabled()
    {
        panel.gameObject.SetActive(false);
    }

    IEnumerator CoFadeIn(float f_time)
    { 
        Color fadeColor = panel.color;
        while (fadeColor.a > 0f)
        {
            time += Time.deltaTime / f_time;
            fadeColor.a = Mathf.Lerp(1, 0, time);
            panel.color = fadeColor;

            yield return null;
        }
    }

    // 투명 -> 불투명
    public  void FadeOut(float f_time, float alpha)
    {
        StartCoroutine(CoFadeOut(f_time, alpha));
    }

    IEnumerator CoFadeOut(float f_time, float alpha)
    {
        Color fadeColor = panel.color;
        //Debug.Log(fadeColor.a);
        while (fadeColor.a <alpha/255)
        {
            //Debug.Log("알파값: " + fadeColor.a);
            time += Time.deltaTime / f_time;
            fadeColor.a = Mathf.Lerp(0,1, time);
            panel.color = fadeColor;

            yield return null;
        }
    }
}
