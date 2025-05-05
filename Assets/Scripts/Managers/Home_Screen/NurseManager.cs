using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NurseManager : MonoBehaviour
{
    // Load the first game scene (index 1)
    public void LoadInterior()
    {
        SceneManager.LoadScene(6);
    }
    public void LoadScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision detected with: " + collision.gameObject.name);
        if(collision.gameObject.CompareTag("Player")){
            Debug.Log("Yes We colliding..");
            LoadInterior();
        }
    }
}
