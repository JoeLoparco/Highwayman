using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class economy_manager : MonoBehaviour
{
    public static economy_manager Instance { get; private set; }
    public int cash = 0;
    // Start is called before the first frame update
    
    public bool buildStageCoach;
  
    private void Awake()
    {
        if (Instance != null && Instance != this)// Implement singleton pattern (only one instance of our Manager can exist this destroys any other instances if they try to occur).
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
    public int getCash(){
        return cash;
    }

    public int addCash(int amount){
        cash += amount;
        return cash;
    }

    public int takeCash(int amount){
        if (cash == 0){
            return cash; // We will not take negative money from a player atp it would be funny if we had some pop up eseentially just saying you're broke or smthn lol
        }
        cash = cash - amount;
        return cash;
    }
}