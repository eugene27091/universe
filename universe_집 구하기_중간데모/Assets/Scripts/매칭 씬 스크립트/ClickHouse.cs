using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ClickHouse : MonoBehaviour
{
    public Text sceneText;
    public Button complete;
    public Button restart;
    public int character1_house; // 김근육 최종 선택 집
    public int character2_house; // 이인싸 최종 선택 집
    public int character3_house; // 박종관 최종 선택 집


    public SpriteRenderer renderer_1; // 김근육
    public SpriteRenderer renderer_1_1; // 김근육 배경
    public SpriteRenderer renderer_2; //이인싸
    public SpriteRenderer renderer_2_1; // 이인싸 배경
    public SpriteRenderer renderer_3; // 박종관
    public SpriteRenderer renderer_3_1; // 박종관 배경
    public bool is_active_1=true; // 1번 매물 버튼 활성화 여부
    public bool is_active_2 = true; // 2번 매물 버튼 활성화 여부
    public bool is_active_3 = true; // 3번 매물 버튼 활성화 여부
    public bool is_active_4 = true; // 4번 매물 버튼 활성화 여부
    public bool is_active_5 = true; // 5번 매물 버튼 활성화 여부
    public bool is_active_6 = true; // 6번 매물 버튼 활성화 여부
    public bool is_active_7 = true; // 7번 매물 버튼 활성화 여부
    public bool is_active_8 = true; // 8번 매물 버튼 활성화 여부

    public int scenenum = 1; //김근육 매칭씬일때 scenenum=1, 이인싸일때 scenenum=2, 박종관일때 scenenum=3
    public Button GetButton1_0; //1번 매물
    public Button GetButton1_1; // 1번 매물 김근육 매칭시
    public Button GetButton1_2; // 1번 매물 이인싸 매칭시
    public Button GetButton1_3; // 1번 매물 박종관 매칭시
    public Button GetButton2_0; //2번 매물
    public Button GetButton2_1; // 2번 매물 김근육 매칭시
    public Button GetButton2_2; // 2번 매물 이인싸 매칭시
    public Button GetButton2_3; // 2번 매물 박종관 매칭시
    public Button GetButton3_0; //3번 매물
    public Button GetButton3_1; // 3번 매물 김근육 매칭시
    public Button GetButton3_2; // 3번 매물 이인싸 매칭시
    public Button GetButton3_3; // 3번 매물 박종관 매칭시
    public Button GetButton4_0; //4번 매물
    public Button GetButton4_1; // 4번 매물 김근육 매칭시
    public Button GetButton4_2; // 4번 매물 이인싸 매칭시
    public Button GetButton4_3; // 4번 매물 박종관 매칭시
    public Button GetButton5_0; //5번 매물
    public Button GetButton5_1; // 5번 매물 김근육 매칭시
    public Button GetButton5_2; // 5번 매물 이인싸 매칭시
    public Button GetButton5_3; // 5번 매물 박종관 매칭시
    public Button GetButton6_0; //6번 매물
    public Button GetButton6_1; // 6번 매물 김근육 매칭시
    public Button GetButton6_2; // 6번 매물 이인싸 매칭시
    public Button GetButton6_3; // 6번 매물 박종관 매칭시
    public Button GetButton7_0; //7번 매물
    public Button GetButton7_1; // 7번 매물 김근육 매칭시
    public Button GetButton7_2; // 7번 매물 이인싸 매칭시
    public Button GetButton7_3; // 7번 매물 박종관 매칭시
    public Button GetButton8_0; //8번 매물
    public Button GetButton8_1; // 8번 매물 김근육 매칭시
    public Button GetButton8_2; // 8번 매물 이인싸 매칭시
    public Button GetButton8_3; // 8번 매물 박종관 매칭시

    void Start()
    {
       
    }
   

    // Update is called once per frame
    void Update()
    {

        if (scenenum == 1) // 김근육 매칭 씬일때
        {
            sceneText.text = "김근육 캐릭터를 적절한 매물과 매칭해주세요.";
            if (GetButton1_0.gameObject == EventSystem.current.currentSelectedGameObject)
            {
                GetButton1_0.gameObject.SetActive(false);
                GetButton1_1.gameObject.SetActive(true);
                renderer_1.sortingLayerName="layer 3";
                renderer_1_1.sortingLayerName = "layer 2";
                renderer_2.sortingLayerName = "layer 6";
                renderer_2_1.sortingLayerName = "layer 5";
                scenenum++;
                is_active_1 = false;
                character1_house = 1;
            }
            else if (GetButton2_0.gameObject == EventSystem.current.currentSelectedGameObject)
            {
                GetButton2_0.gameObject.SetActive(false);
                GetButton2_1.gameObject.SetActive(true);
                renderer_1.sortingLayerName = "layer 3";
                renderer_1_1.sortingLayerName = "layer 2";
                renderer_2.sortingLayerName = "layer 6";
                renderer_2_1.sortingLayerName = "layer 5";
                scenenum++;
                is_active_2 = false;
                character1_house = 2;
            }
            else if (GetButton3_0.gameObject == EventSystem.current.currentSelectedGameObject)
            {
                GetButton3_0.gameObject.SetActive(false);
                GetButton3_1.gameObject.SetActive(true);
                renderer_1.sortingLayerName = "layer 3";
                renderer_1_1.sortingLayerName = "layer 2";
                renderer_2.sortingLayerName = "layer 6";
                renderer_2_1.sortingLayerName = "layer 5";
                scenenum++;
                is_active_3 = false;
                character1_house = 3;
            }
            else if (GetButton4_0.gameObject == EventSystem.current.currentSelectedGameObject)
            {
                GetButton4_0.gameObject.SetActive(false);
                GetButton4_1.gameObject.SetActive(true);
                renderer_1.sortingLayerName = "layer 3";
                renderer_1_1.sortingLayerName = "layer 2";
                renderer_2.sortingLayerName = "layer 6";
                renderer_2_1.sortingLayerName = "layer 5";
                scenenum++;
                is_active_4 = false;
                character1_house = 4;
            }
            else if (GetButton5_0.gameObject == EventSystem.current.currentSelectedGameObject)
            {
                GetButton5_0.gameObject.SetActive(false);
                GetButton5_1.gameObject.SetActive(true);
                renderer_1.sortingLayerName = "layer 3";
                renderer_1_1.sortingLayerName = "layer 2";
                renderer_2.sortingLayerName = "layer 6";
                renderer_2_1.sortingLayerName = "layer 5";
                scenenum++;
                is_active_5 = false;
                character1_house = 5;
            }
            else if (GetButton6_0.gameObject == EventSystem.current.currentSelectedGameObject)
            {
                GetButton6_0.gameObject.SetActive(false);
                GetButton6_1.gameObject.SetActive(true);
                renderer_1.sortingLayerName = "layer 3";
                renderer_1_1.sortingLayerName = "layer 2";
                renderer_2.sortingLayerName = "layer 6";
                renderer_2_1.sortingLayerName = "layer 5";
                scenenum++;
                is_active_6 = false;
                character1_house = 6;
            }
            else if (GetButton7_0.gameObject == EventSystem.current.currentSelectedGameObject)
            {
                GetButton7_0.gameObject.SetActive(false);
                GetButton7_1.gameObject.SetActive(true);
                renderer_1.sortingLayerName = "layer 3";
                renderer_1_1.sortingLayerName = "layer 2";
                renderer_2.sortingLayerName = "layer 6";
                renderer_2_1.sortingLayerName = "layer 5";
                scenenum++;
                is_active_7 = false;
                character1_house = 7;
            }
            else if (GetButton8_0.gameObject == EventSystem.current.currentSelectedGameObject)
            {
                GetButton8_0.gameObject.SetActive(false);
                GetButton8_1.gameObject.SetActive(true);
                renderer_1.sortingLayerName = "layer 3";
                renderer_1_1.sortingLayerName = "layer 2";
                renderer_2.sortingLayerName = "layer 6";
                renderer_2_1.sortingLayerName = "layer 5";
                scenenum++;
                is_active_8 = false;
                character1_house = 8;
            }
        }
        else if(scenenum==2) // 이인싸 매칭 씬일때
        {
            sceneText.text = "이인싸 캐릭터를 적절한 매물과 매칭해주세요.";
            
            if (GetButton1_0.gameObject == EventSystem.current.currentSelectedGameObject&&is_active_1==true)
            {
                GetButton1_0.gameObject.SetActive(false);
                GetButton1_2.gameObject.SetActive(true);
                renderer_2.sortingLayerName = "layer 3";
                renderer_2_1.sortingLayerName = "layer 2";
                renderer_3.sortingLayerName = "layer 6";
                renderer_3_1.sortingLayerName = "layer 5";
                scenenum++;
                is_active_1 = false;
                character2_house = 1;
            }
            else if (GetButton2_0.gameObject == EventSystem.current.currentSelectedGameObject&&is_active_2==true)
            {
                GetButton2_0.gameObject.SetActive(false);
                GetButton2_2.gameObject.SetActive(true);
                renderer_2.sortingLayerName = "layer 3";
                renderer_2_1.sortingLayerName = "layer 2";
                renderer_3.sortingLayerName = "layer 6";
                renderer_3_1.sortingLayerName = "layer 5";
                scenenum++;
                is_active_2 = false;
                character2_house = 2;
            }
            else if (GetButton3_0.gameObject == EventSystem.current.currentSelectedGameObject && is_active_3 == true)
            {
                GetButton3_0.gameObject.SetActive(false);
                GetButton3_2.gameObject.SetActive(true);
                renderer_2.sortingLayerName = "layer 3";
                renderer_2_1.sortingLayerName = "layer 2";
                renderer_3.sortingLayerName = "layer 6";
                renderer_3_1.sortingLayerName = "layer 5";
                scenenum++;
                is_active_3 = false;
                character2_house = 3;
            }
            else if (GetButton4_0.gameObject == EventSystem.current.currentSelectedGameObject && is_active_4 == true)
            {
                GetButton4_0.gameObject.SetActive(false);
                GetButton4_2.gameObject.SetActive(true);
                renderer_2.sortingLayerName = "layer 3";
                renderer_2_1.sortingLayerName = "layer 2";
                renderer_3.sortingLayerName = "layer 6";
                renderer_3_1.sortingLayerName = "layer 5";
                scenenum++;
                is_active_4 = false;
                character2_house = 4;
            }
            else if (GetButton5_0.gameObject == EventSystem.current.currentSelectedGameObject && is_active_5 == true)
            {
                GetButton5_0.gameObject.SetActive(false);
                GetButton5_2.gameObject.SetActive(true);
                renderer_2.sortingLayerName = "layer 3";
                renderer_2_1.sortingLayerName = "layer 2";
                renderer_3.sortingLayerName = "layer 6";
                renderer_3_1.sortingLayerName = "layer 5";
                scenenum++;
                is_active_5 = false;
                character2_house = 5;
            }
            else if (GetButton6_0.gameObject == EventSystem.current.currentSelectedGameObject && is_active_6 == true)
            {
                GetButton6_0.gameObject.SetActive(false);
                GetButton6_2.gameObject.SetActive(true);
                renderer_2.sortingLayerName = "layer 3";
                renderer_2_1.sortingLayerName = "layer 2";
                renderer_3.sortingLayerName = "layer 6";
                renderer_3_1.sortingLayerName = "layer 5";
                scenenum++;
                is_active_6 = false;
                character2_house = 6;
            }
            else if (GetButton7_0.gameObject == EventSystem.current.currentSelectedGameObject && is_active_7 == true)
            {
                GetButton7_0.gameObject.SetActive(false);
                GetButton7_2.gameObject.SetActive(true);
                renderer_2.sortingLayerName = "layer 3";
                renderer_2_1.sortingLayerName = "layer 2";
                renderer_3.sortingLayerName = "layer 6";
                renderer_3_1.sortingLayerName = "layer 5";
                scenenum++;
                is_active_7 = false;
                character2_house = 7;
            }
            else if (GetButton8_0.gameObject == EventSystem.current.currentSelectedGameObject && is_active_8 == true)
            {
                GetButton8_0.gameObject.SetActive(false);
                GetButton8_2.gameObject.SetActive(true);
                renderer_2.sortingLayerName = "layer 3";
                renderer_2_1.sortingLayerName = "layer 2";
                renderer_3.sortingLayerName = "layer 6";
                renderer_3_1.sortingLayerName = "layer 5";
                scenenum++;
                is_active_8 = false;
                character2_house = 8;
            }
        }
        else if (scenenum == 3) // 박종관 매칭 씬일때
        {
            sceneText.text = "박종관 캐릭터를 적절한 매물과 매칭해주세요.";
            if (GetButton1_0.gameObject == EventSystem.current.currentSelectedGameObject && is_active_1 == true)
            {
                GetButton1_0.gameObject.SetActive(false);
                GetButton1_3.gameObject.SetActive(true);
                renderer_3.sortingLayerName = "layer 3";
                renderer_3_1.sortingLayerName = "layer 2";
                scenenum++;
                is_active_1 = false;
                character3_house = 1;
            }
            if (GetButton2_0.gameObject == EventSystem.current.currentSelectedGameObject && is_active_2 == true)
            {
                GetButton2_0.gameObject.SetActive(false);
                GetButton2_3.gameObject.SetActive(true);
                renderer_3.sortingLayerName = "layer 3";
                renderer_3_1.sortingLayerName = "layer 2";
                scenenum++;
                is_active_2 = false;
                character3_house = 2;
            }
            if (GetButton3_0.gameObject == EventSystem.current.currentSelectedGameObject && is_active_3 == true)
            {
                GetButton3_0.gameObject.SetActive(false);
                GetButton3_3.gameObject.SetActive(true);
                renderer_3.sortingLayerName = "layer 3";
                renderer_3_1.sortingLayerName = "layer 2";
                scenenum++;
                is_active_3 = false;
                character3_house = 3;
            }
            if (GetButton4_0.gameObject == EventSystem.current.currentSelectedGameObject && is_active_4 == true)
            {
                GetButton4_0.gameObject.SetActive(false);
                GetButton4_3.gameObject.SetActive(true);
                renderer_3.sortingLayerName = "layer 3";
                renderer_3_1.sortingLayerName = "layer 2";
                scenenum++;
                is_active_4 = false;
                character3_house = 4;
            }
            if (GetButton5_0.gameObject == EventSystem.current.currentSelectedGameObject && is_active_5 == true)
            {
                GetButton5_0.gameObject.SetActive(false);
                GetButton5_3.gameObject.SetActive(true);
                renderer_3.sortingLayerName = "layer 3";
                renderer_3_1.sortingLayerName = "layer 2";
                scenenum++;
                is_active_5 = false;
                character3_house = 5;
            }
         
            if (GetButton6_0.gameObject == EventSystem.current.currentSelectedGameObject && is_active_6 == true)
            {
                GetButton6_0.gameObject.SetActive(false);
                GetButton6_3.gameObject.SetActive(true);
                renderer_3.sortingLayerName = "layer 3";
                renderer_3_1.sortingLayerName = "layer 2";
                scenenum++;
                is_active_6 = false;
                character3_house = 6;
            }
            if (GetButton7_0.gameObject == EventSystem.current.currentSelectedGameObject && is_active_7 == true)
            {
                GetButton7_0.gameObject.SetActive(false);
                GetButton7_3.gameObject.SetActive(true);
                renderer_3.sortingLayerName = "layer 3";
                renderer_3_1.sortingLayerName = "layer 2";
                scenenum++;
                is_active_7 = false;
                character3_house = 7;
            }
            if (GetButton8_0.gameObject == EventSystem.current.currentSelectedGameObject && is_active_8 == true)
            {
                GetButton8_0.gameObject.SetActive(false);
                GetButton8_3.gameObject.SetActive(true);
                renderer_3.sortingLayerName = "layer 3";
                renderer_3_1.sortingLayerName = "layer 2";
                scenenum++;
                is_active_8 = false;
                character3_house = 8;
            }
        }
        else if (scenenum == 4) // 매칭 끝냈을때
        {
            sceneText.text = "매물을 다시 둘러볼지, 매칭을 최종 결정할지 선택해주세요.";
            restart.gameObject.SetActive(true);
            complete.gameObject.SetActive(true);
        }
    }
}
