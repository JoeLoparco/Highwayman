using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BuildingMenuManager : MonoBehaviour
{
    void Awake()
    {
        LogToFile("BuildingMenuManager Awake started");
        
        // Check if economy manager exists immediately
        bool economyExists = economy_manager.Instance != null;
        LogToFile("Economy manager exists in Awake: " + economyExists);
        
        LogToFile("BuildingMenuManager Awake completed");
    }

    void Start()
    {
        LogToFile("BuildingMenuManager Start started");
        
        // Check for UI elements
        UnityEngine.UI.Button[] buttons = GetComponentsInChildren<UnityEngine.UI.Button>(true);
        LogToFile("Found " + buttons.Length + " buttons");
        
        // List each button (helpful to see if they have the correct components)
        foreach (var button in buttons)
        {
            LogToFile("Button: " + button.name + " has onClick listeners: " + button.onClick.GetPersistentEventCount());
        }
        
        // Check for the economy manager
        LogToFile("Economy manager exists: " + (economy_manager.Instance != null));
        if (economy_manager.Instance != null)
        {
            LogToFile("Current cash: " + economy_manager.Instance.getCash());
        }
        
        // Check event system
        var eventSystem = FindObjectOfType<UnityEngine.EventSystems.EventSystem>();
        LogToFile("Event system exists: " + (eventSystem != null));
        
        // Check canvas
        var canvas = GetComponentInParent<Canvas>();
        LogToFile("Parent canvas: " + (canvas != null ? canvas.name : "none"));
        
        LogToFile("BuildingMenuManager Start completed");
    }

    //public Vector2 posVec = new Vector2(300,80)
    // Start is called before the first frame update
    public void BuildGunSmith(){
        if(economy_manager.Instance.getCash() >= 1000){
            economy_manager.Instance.takeCash(1000);
            // We Need to add the Build Functionality Here Lmao
            economy_manager.Instance.buildGunSmith = true;
            SceneManager.LoadScene(1);
        }
    }

    public void BuildStageCoach(){
        if(economy_manager.Instance.getCash() >= 500){
            economy_manager.Instance.takeCash(500);
            // We Need to add the Build Functionality Here Lmao
            economy_manager.Instance.buildStageCoach = true;
            SceneManager.LoadScene(1);
        }
    }

    public void BuildNurse(){
        if(economy_manager.Instance.getCash() >= 1000){
            economy_manager.Instance.takeCash(1000);
            // We Need to add the Build Functionality Here Lmao
            economy_manager.Instance.buildNurse = true;
            SceneManager.LoadScene(1);
        }
    }

    public void BuildStore(){
        if(economy_manager.Instance.getCash() >= 500){
            economy_manager.Instance.takeCash(500);
            // We Need to add the Build Functionality Here Lmao
            economy_manager.Instance.buildStore = true;
            SceneManager.LoadScene(1);
        }
    }

     public void BuildStables(){
        if(economy_manager.Instance.getCash() >= 500){
            economy_manager.Instance.takeCash(500);
            // Sets a Flag in the Economy Manager that the Building Manager uses to decide which Buildings to build. 
            economy_manager.Instance.buildStable = true;
            SceneManager.LoadScene(1);
        }
    }
    
    public void LoadScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }

    public void ReturnToGame()
    {
        SceneManager.LoadScene(1);
    }

    void LogToFile(string message)
    {
        try {
            string path = Application.persistentDataPath + "/building_debug.txt";
            System.IO.File.AppendAllText(path, "\n" + System.DateTime.Now + ": " + message);
        } catch (System.Exception e) {
            Debug.LogError("Failed to write log: " + e.Message);
        }
    }

}
