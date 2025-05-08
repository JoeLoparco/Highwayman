using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GunSmithMenuManager : MonoBehaviour
{
    //public Vector2 posVec = new Vector2(300,80)
    // Start is called before the first frame update
    public void IncreaseDamage1(){
        if(economy_manager.Instance.getCash() >= 250){
            economy_manager.Instance.playerDamage += 25;
            economy_manager.Instance.takeCash(250);
            Debug.Log("Damage Added 25");
            Debug.Log(economy_manager.Instance.playerDamage);
            SceneManager.LoadScene(1);
        }
    }

    public void IncreaseDamage2(){
        if(economy_manager.Instance.getCash() >= 500){
            economy_manager.Instance.playerDamage += 75;
            economy_manager.Instance.takeCash(500);
            Debug.Log("Damage Added 25");
            Debug.Log(economy_manager.Instance.playerDamage);
            SceneManager.LoadScene(1);
        }
    }

    public void IncreaseDamage3(){
        if(economy_manager.Instance.getCash() >= 1500){
            economy_manager.Instance.playerDamage += 250;
            economy_manager.Instance.takeCash(1500);
            Debug.Log("Damage Added 25");
            Debug.Log(economy_manager.Instance.playerDamage);
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
