using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyBagController : MonoBehaviour
{
    // Start is called before the first frame update
  private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision detected with: " + collision.gameObject.name);
        if(collision.gameObject.CompareTag("Player")){
            Debug.Log("Giving Free Money!!!");
            economy_manager.Instance.addCash(100);
        }
    }
}
