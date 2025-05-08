using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WaveDisplayManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI waveText;
    [SerializeField] private TextMeshProUGUI healthText;
    GameObject Player;
    PlayerScript playerScript;

    void Awake(){
         //Debug.Log("What is happening");
         Player = GameObject.Find("Player");
         if(Player == null){
            //Debug.Log("Bruh");
         }else{
            //Debug.Log("Player found successfully! Name: " + Player.name);
         }
    }
    void FixedUpdate(){
        playerScript = Player.GetComponent<PlayerScript>();
        waveText.text = "WAVE: " + combat_manager.Instance.wave.ToString();
        healthText.text = "*HEALTH* " + playerScript.health.ToString() + " *";
    }
    
}