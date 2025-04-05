using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InteriorManager : MonoBehaviour
{

    public void LoadTown()
    {
        SceneManager.LoadScene(1);
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
            LoadTown();
        }
    }

}
