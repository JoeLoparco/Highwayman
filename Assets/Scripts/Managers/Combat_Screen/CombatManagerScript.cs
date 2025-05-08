using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class combat_manager : MonoBehaviour
{
    public static combat_manager Instance { get; set; }
    public  List<GameObject> rosterGOs = new List<GameObject>();
    public GameObject bandit_PreFab;
    public int wave = 1;    
    public int wavesLeft = 3;
    public int enemies = -1;
    public bool playerTurn = true;
    // Start is called before the first frame update

    void spawnWave(){
        // Right now each wave will be hardcoded but these will be dynamically generate in the future
        if (wave == 1){
            enemies = 2;
            Vector3 spawnPosition_0 = new Vector3(5, 2, 0);
            GameObject bandit_0 = Instantiate(bandit_PreFab, spawnPosition_0, Quaternion.identity);
            Vector3 spawnPosition_1 = new Vector3(5, -2, 0);
            GameObject bandit_1 = Instantiate(bandit_PreFab, spawnPosition_1, Quaternion.identity);
        }

        if (wave == 2){
            enemies = 3;
            Vector3 spawnPosition_0 = new Vector3(5, 3, 0);
            GameObject bandit_0 = Instantiate(bandit_PreFab, spawnPosition_0, Quaternion.identity);
            Vector3 spawnPosition_1 = new Vector3(5, -3, 0);
            GameObject bandit_1 = Instantiate(bandit_PreFab, spawnPosition_1, Quaternion.identity);
            Vector3 spawnPosition_2 = new Vector3(5, 0, 0);
            GameObject bandit_2 = Instantiate(bandit_PreFab, spawnPosition_2, Quaternion.identity);
        }

      if (wave == 3){
            enemies = 4;
            Vector3 spawnPosition_0 = new Vector3(5, 2, 0);
            GameObject bandit_0 = Instantiate(bandit_PreFab, spawnPosition_0, Quaternion.identity);
            Vector3 spawnPosition_1 = new Vector3(5, -2, 0);
            GameObject bandit_1 = Instantiate(bandit_PreFab, spawnPosition_1, Quaternion.identity);
            Vector3 spawnPosition_2 = new Vector3(3.9f, 2.8f, 0);
            GameObject bandit_2 = Instantiate(bandit_PreFab, spawnPosition_2, Quaternion.identity);
            Vector3 spawnPosition_3 = new Vector3(5.9f, 0, 0);
            GameObject bandit_3 = Instantiate(bandit_PreFab, spawnPosition_3, Quaternion.identity);
            Vector3 spawnPosition_4 = new Vector3(3.9f, -2.8f, 0);
            GameObject bandit_4 = Instantiate(bandit_PreFab, spawnPosition_4, Quaternion.identity);
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
        spawnWave();
    }

    void Update(){
        int rosterSize = rosterGOs.Count;
        if(playerTurn == false && enemies > 0){
                Debug.Log("Enemy Player Turn!");
                int randomEnemy = Random.Range(0, rosterSize);
                if(rosterGOs[randomEnemy] != null){
                    GameObject player_object = rosterGOs[randomEnemy];
                    PlayerScript playerScript = player_object.GetComponent<PlayerScript>();
                    playerScript.health -= 50 ;
                }
                Debug.Log("randomEnemy attacked!");
                playerTurn = !playerTurn;
            }  
            if(enemies == 0){
                // Handle Necesarry Acounting
                wavesLeft -= 1;
                wave += 1;
                enemies = -1;
                if(wavesLeft == 0){
                    SceneManager.LoadScene(9); // Load Post Combat Scene
                }else{
                    spawnWave();
                }
            }
    }

    public void LoadScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
    
}
