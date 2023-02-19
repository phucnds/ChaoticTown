using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EditorInitialisationLoader : MonoBehaviour
{
#if UNITY_EDITOR
    public GameSceneSO initializationScene;
    public int targetFramerate = 0; // For debugging purposes

    private void Awake()
    {
        Application.targetFrameRate = targetFramerate; // For debugging purposes

        for (int i = 0; i < SceneManager.sceneCount; ++i)
        {
            Scene scene = SceneManager.GetSceneAt(i);
            if (scene.name == initializationScene.sceneName)
            {
                return;
            }
        }
        SceneManager.LoadSceneAsync(initializationScene.sceneName, LoadSceneMode.Additive);
    }
#endif
}
