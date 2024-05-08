using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainStory : MonoBehaviour
{
    private void OnEnable()
    {
        //Only specifying the sceneName or scneBuildIndex  will load the scene with Single Mode
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }

}
