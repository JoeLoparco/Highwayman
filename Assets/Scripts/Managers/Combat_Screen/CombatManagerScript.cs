using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class combat_manager : MonoBehaviour
{
    public static combat_manager Instance { get; set; }

    public  List<GameObject> rosterGOs = new List<GameObject>();

    public GameObject bandit_PreFab;
    public int wave = 1;
    public int enemies = -1;
    public bool playerTurn = false;
    // Start is called before the first frame update

    void Start(){
        if (wave == 1){
            enemies = 2;
            Vector3 spawnPosition_0 = new Vector3(5, 2, 0);
            GameObject bandit_0 = Instantiate(bandit_PreFab, spawnPosition_0, Quaternion.identity);
            Vector3 spawnPosition_1 = new Vector3(5, -2, 0);
            GameObject bandit_1 = Instantiate(bandit_PreFab, spawnPosition_1, Quaternion.identity);
        }

    }
    private void Awake()
    {
        if (Instance != null && Instance != this)// Implement singleton pattern (only one instance of our Manager can exist this destroys any other instances if they try to occur).
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
    }

    void Update(){
    int rosterSize = rosterGOs.Count;
      if(playerTurn == false && enemies > 0){
            Debug.Log("Enemy Player Turn!");
            int randomEnemy = Random.Range(0, rosterSize);
            if(rosterGOs[randomEnemy] != null){
                GameObject player_object = rosterGOs[randomEnemy];
                PlayerScript playerScript = player_object.GetComponent<PlayerScript>();
                playerScript.health -= 51;
            }
            Debug.Log("randomEnemy attacked!");
            playerTurn = !playerTurn;
        }  
        if(enemies == 0){
            wave +=1;
            enemies = -1;
        }
    }
    
}
