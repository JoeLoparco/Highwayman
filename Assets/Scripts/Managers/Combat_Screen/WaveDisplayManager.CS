using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WaveDisplayManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI waveText;
    
    void Update(){
        waveText.text = "WAVE: " + combat_manager.Instance.wave.ToString();
    }
    
}