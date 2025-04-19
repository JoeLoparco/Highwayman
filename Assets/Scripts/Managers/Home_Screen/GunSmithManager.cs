using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GunSmithManager : MonoBehaviour
{
    public void LoadInterior()
    {
        SceneManager.LoadScene(3); // Note this will break rn cuase I need to add the scene the
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