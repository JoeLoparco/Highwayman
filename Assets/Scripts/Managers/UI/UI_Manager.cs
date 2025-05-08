using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_Manager : MonoBehaviour
{
    // Load the first game scene (index 1)
    public void LoadBM()
    {
        SceneManager.LoadScene(4);
    }

    public void LoadCS()
    {
        SceneManager.LoadScene(8);
        if(economy_manager.Instance.tutorialDone != true){
            economy_manager.Instance.tutorialDone = true;
        }
    }

    public void LoadGS()
    {
        SceneManager.LoadScene(11);
    }

    public void Heal()
    {
        if(economy_manager.Instance.getCash() >= 75){
            economy_manager.Instance.playerHealth += 100;
             SceneManager.LoadScene(1);
        }
    }

    public void LoadScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
