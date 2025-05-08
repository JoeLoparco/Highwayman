using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    public int health;
    public int damage;
    int rosterIndex = -1; // For addition of additnal Npc charcaters and a roster in the future.
    // Start is called before the first frame update
    void Start()
    {
        health = economy_manager.Instance.playerHealth;
        damage = economy_manager.Instance.playerDamage;
        combat_manager.Instance.rosterGOs.Add(gameObject);
        rosterIndex = combat_manager.Instance.rosterGOs.Count-1; 
        //Debug.Log(rosterIndex);  
        //Debug.Log(combat_manager.Instance.rosterGOs[rosterIndex]);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Debug.Log("Current Player Health:");
        Debug.Log(health);
        if(health <=0){
            Destroy(gameObject);
            SceneManager.LoadScene(10); // Load Death Screen
        }
    }

    public void LoadScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
