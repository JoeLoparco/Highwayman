using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CashDisplayManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI cashText;
    
    void Update()
    {
        cashText.text = "CASH: $" + economy_manager.Instance.getCash().ToString();
    }
}
