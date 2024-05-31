using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    [SerializeField] private GameObject endScreen;
    [SerializeField] private bool isAlive = false;

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.tag == "Player" && !isAlive)
        {
            SceneManager.LoadScene("Dead End");
        }

        if(other.gameObject.tag == "Player" && isAlive)
        {
            endScreen.SetActive(true);
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene("Tutorial Day 1");
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
    public void Quit()
    {
        Application.Quit();
    }

}
