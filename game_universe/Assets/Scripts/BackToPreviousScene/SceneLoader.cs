using UnityEngine;
public class SceneLoader : MonoBehaviour
{
    public void back() // 지도에서 다시 매물 둘러보는 화면으로 이동
    {
        // reload the current scene
        SceneManager.LoadPreviousScene();
    }

    public void back2() // 메일함에서 다시 매물 둘러보는 화면으로 이동
    {
        SceneManager.LoadPreviousScene2();
    }


}
