using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RespawnMenu : MonoBehaviour
{
    /*public void StartGame()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        SceneManager.LoadScene("Macguffin");
        SceneManager.SetActiveScene(SceneManager.GetSceneByName("Macguffin"));
    }*/

    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.CompareTag("Player"))
        {
        SceneManager.LoadScene("Macguffin");
        //SceneManager.SetActiveScene(SceneManager.GetSceneByName("Macguffin"));
        }
    }
}
