using UnityEngine;
using UnityEngine.SceneManagement;

// Debugging used for Build problems 
public class SceneLoadDebugger : MonoBehaviour
{
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
        SceneManager.sceneLoaded += OnSceneLoaded;
        
        string logPath = Application.persistentDataPath + "/scene_debug.txt";
        System.IO.File.WriteAllText(logPath, "Scene debugger started: " + System.DateTime.Now);
    }
    
    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        string logPath = Application.persistentDataPath + "/scene_debug.txt";
        System.IO.File.AppendAllText(logPath, 
            "\nScene loaded: " + scene.name + " (index: " + scene.buildIndex + ") at " + System.DateTime.Now);
    }
    
    void OnDestroy()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
}