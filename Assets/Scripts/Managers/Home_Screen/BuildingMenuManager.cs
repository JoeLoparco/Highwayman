using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BuildingMenuManager : MonoBehaviour
{
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

}
