using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerScript : MonoBehaviour
{
    public int health = 100;
    int rosterIndex = -1;
    // Start is called before the first frame update
    void Start()
    {
        combat_manager.Instance.rosterGOs.Add(gameObject);
        rosterIndex = combat_manager.Instance.rosterGOs.Count-1; 
        Debug.Log(rosterIndex);  
        Debug.Log(combat_manager.Instance.rosterGOs[rosterIndex]);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Debug.Log("Current Player HEalth:");
        Debug.Log(health);
        if(health <=0){
            Destroy(gameObject);
        }
    }
}
