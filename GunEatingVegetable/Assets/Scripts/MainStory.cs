using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainStory : MonoBehaviour
{
     void Start()
    {
        StartCoroutine(NextScene());
    }
    void Update()
    {
        
    }
    IEnumerator NextScene()
    {
        yield return new WaitForSeconds(25.0f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}

