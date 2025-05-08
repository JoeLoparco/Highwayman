using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour
{
    int health = 50;
    // Start is called before the first frame update

    // Update is called once per frame 
    void OnMouseDown()
    {
        if(combat_manager.Instance.playerTurn == true){
            //Debug.Log("Your Turn!!!!");
            health -= 50;
            //Debug.Log("This is working");
            //Debug.Log(combat_manager.Instance.playerTurn);
            if(health <= 0) {
                Destroy(gameObject);
                economy_manager.Instance.addCash(75);
                combat_manager.Instance.enemies -= 1;  
            }
            combat_manager.Instance.playerTurn = !combat_manager.Instance.playerTurn;
            //Debug.Log("Player Attacked!!!");
        }
        
    }
}
