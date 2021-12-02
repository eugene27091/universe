using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SceneManager : MonoBehaviour
{
    private static bool destroyed = false;
    private static object lockObject = new object();
    private static SceneManager instance;
    private Stack<int> loadedLevels;

    public static SceneManager Instance
    {
        get
        {
            if (destroyed)
            {
                Debug.LogWarning("[Singleton] Instance '" + typeof(SceneManager) +
                    "' already destroyed. Returning null.");
                return null;
            }

            lock (lockObject)
            {
                if (instance == null)
                {
                    // Search for existing instance.
                    instance = (SceneManager)FindObjectOfType(typeof(SceneManager));

                    // Create new instance if one doesn't already exist.
                    if (instance == null)
                    {
                        // Need to create a new GameObject to attach the singleton to.
                        var singletonObject = new GameObject();
                        instance = singletonObject.AddComponent<SceneManager>();
                        singletonObject.name = typeof(SceneManager).ToString() + " (Singleton)";

                        // Make instance persistent.
                        DontDestroyOnLoad(singletonObject);
                    }
                }

                return instance;
            }
        }
    }

    public static UnityEngine.SceneManagement.Scene GetActiveScene()
    {
        return UnityEngine.SceneManagement.SceneManager.GetActiveScene();
    }

    public static void LoadScene(int buildIndex)
    {
        Instance.loadedLevels.Push(GetActiveScene().buildIndex);
        UnityEngine.SceneManagement.SceneManager.LoadScene(buildIndex);
    }

    public static void LoadScene(string sceneName)
    {
        Instance.loadedLevels.Push(GetActiveScene().buildIndex);
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
    }


  


    public static void LoadPreviousScene() //쌓인 씬들을 1번 pop해서 호출( 매물 둘러보는 도중 지도를 클릭했을때 x 버튼 누르면 다시 매물둘러보는 화면으로 이동)
    {
        if (Instance.loadedLevels.Count > 0)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(Instance.loadedLevels.Pop());
        }
        else
        {
            Debug.LogError("No previous scene loaded");
            // If you want, you can call `Application.Quit()` instead
        }
    }

    public static void LoadPreviousScene2() //쌓인 씬들을 2번 pop해서 호출( 매물 둘러보는 도중 메일를 클릭했을때 확인 버튼을 누르면 다시 매물둘러보는 화면으로 이동)
    {
        if (Instance.loadedLevels.Count > 0)
        {
            Instance.loadedLevels.Pop();
            UnityEngine.SceneManagement.SceneManager.LoadScene(Instance.loadedLevels.Pop());
        }
        else
        {
            Debug.LogError("No previous scene loaded");
            // If you want, you can call `Application.Quit()` instead
        }
    }


    private void Awake()
    {
        loadedLevels = new Stack<int>();
    }

    private void OnApplicationQuit()
    {
        destroyed = true;
    }

    private void OnDestroy()
    {
        destroyed = true;
    }
}

