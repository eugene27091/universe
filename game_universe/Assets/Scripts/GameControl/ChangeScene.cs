using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ChangeScene : MonoBehaviour
{
    public AudioSource audiosource;


    // Start is called before the first frame update
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


 

    public void SceneChange6() // 지도에서 매물 선택
    {
        SceneManager.LoadScene("Map");
    }

    public void SceneChange7() // 매물 둘러보는 도중 지도 보기
    {
        SceneManager.LoadScene("Map(no mail button)");
    }


    // 게임 도중 메일함 보기
    public void SceneChange8()
    {
        SceneManager.LoadScene("메일함 첫화면");
    }

    public void SceneChange9()
    {
        SceneManager.LoadScene("김근육");
    }

    public void SceneChange10()
    {
        SceneManager.LoadScene("이인싸");
    }

    public void SceneChange11()
    {
        SceneManager.LoadScene("박종관");
    }

    // Update is called once per frame

    public void moveTooutside_1()
    {
        SceneManager.LoadScene("주변환경_1번");
    }
    public void moveToBath_1()
    {
        SceneManager.LoadScene("화장실_1번");
    }
    public void moveToBed_1()
    {
        SceneManager.LoadScene("방_1번");
    }

    // 2번 매물 이동
    public void moveToRoom1_2()
    {
        SceneManager.LoadScene("room1_2번");
    }
    public void moveToRoom2_2()
    {
        SceneManager.LoadScene("room2_2번");
    }
    public void moveToToilet_2()
    {
        SceneManager.LoadScene("toilet_2번");
    }

    // 3번 매물 이동
    public void moveToBed_3()
    {
        SceneManager.LoadScene("방_3번");
    }

    public void moveToBath_3()
    {
        SceneManager.LoadScene("화장실_3번");
    }

    //4번 매물 이동

    public void moveToBed_4()
    {
        SceneManager.LoadScene("방_4번");
    }

    public void moveToBath_4()
    {
        SceneManager.LoadScene("화장실_4번");
    }

    // 5번 매물 이동

    public void moveToToilet_5()
    {
        SceneManager.LoadScene("화장실_5번");
    }
    public void moveTolivingroom_5()
    {
        SceneManager.LoadScene("거실_5번");
    }
    public void moveToBed_5()
    {
        SceneManager.LoadScene("방_5번");
    }
    public void moveToKitchen_5()
    {
        SceneManager.LoadScene("부엌_5번");
    }

    // 6번 매물 이동

    public void moveToBed_6()
    {
        SceneManager.LoadScene("방_6번");
    }
    public void moveToKitchen_6()
    {
        SceneManager.LoadScene("분리형 주방_6번");
    }
    public void moveToToilet_6()
    {
        SceneManager.LoadScene("화장실_6번");
    }

    // 7번 매물 이동
    public void moveToBath_7()
    {
        SceneManager.LoadScene("bathroom7_7번");
    }

    public void moveToBed_7()
    {
        SceneManager.LoadScene("bed7_7번");
    }

    // 8번 매물 이동

    public void moveToBath_8()
    {
        SceneManager.LoadScene("bathroom8_8번");
    }
    public void moveToBed_8()
    {
        SceneManager.LoadScene("bed8_8번");
    }
    public void moveToKitchen_8()
    {
        SceneManager.LoadScene("kitchen_8번");
    }

    public void movePainting_8()
    {
        SceneManager.LoadScene("movePainting_8번");
    }

    public void moveOutside_8()
    {
        SceneManager.LoadScene("outside_8번");
    }

    // 1번 매물 첫화면
    public void house_1()
    {
        SceneManager.LoadScene("방_1번");
    }

    //2번 매물 첫화면
    public void house_2()
    {
        SceneManager.LoadScene("room1_2번");
    }

    //3번 매물 첫화면
    public void house_3()
    {
        SceneManager.LoadScene("방_3번");
    }
    //4번 매물 첫화면
    public void house_4()
    {
        SceneManager.LoadScene("방_4번");
    }
    //5번 매물 첫화면
    public void house_5()
    {
        SceneManager.LoadScene("거실_5번");
    }
    //6번 매물 첫화면
    public void house_6()
    {
        SceneManager.LoadScene("방_6번");
    }
    //7번 매물 첫화면
    public void house_7()
    {
        SceneManager.LoadScene("bed7_7번");
    }
    //8번 매물 첫화면
    public void house_8()
    {
        SceneManager.LoadScene("bed8_8번");
    }

    public void backToMap()
    {
        SceneManager.LoadScene("Map");
    }

    public void startStory()
    {
        SceneManager.LoadScene("Story");
    }


    public void goToMail()
    {
        SceneManager.LoadScene("Scene1 - 메일함 첫화면");
    }

    public void goToMatching()
    {
        SceneManager.LoadScene("매칭 씬");
    }

    public void goToPlayGame()
    {
        SceneManager.LoadScene("nickname");
    }
    public void GameFirstScene()
    {
        SceneManager.LoadScene("게임 시작");
    }
    public void GameMethod_1()
    {
        SceneManager.LoadScene("게임 방법 1");
    }

    public void GameMethod_2()
    {
        SceneManager.LoadScene("게임 방법 2");
    }

    public void GameMethod_3()
    {
        SceneManager.LoadScene("게임 방법 3");
    }
    public void AudioPlay()
    {
        audiosource.Play();
    }

    public void Replay()
    {
        SceneManager.LoadScene("매칭 씬");
    }
    public void KeepContracting()
    {
        SceneManager.LoadScene("계약하러 가기");
    }

    public void tip_1()
    {
        SceneManager.LoadScene("부동산 거래 팁 1,2");
    }
    public void tip_2()
    {
        SceneManager.LoadScene("부동산 거래 팁 3,4");
    }

    public void tip_3()
    {
        SceneManager.LoadScene("부동산 거래 팁 5");
    }

    public void contract_1()
    {
        SceneManager.LoadScene("클린빌라_김근육");
    }
    public void contract_5()
    {
        SceneManager.LoadScene("roomStart");
    }

    public void contract_6()
    {
        SceneManager.LoadScene("6_이인싸");
    }
}


