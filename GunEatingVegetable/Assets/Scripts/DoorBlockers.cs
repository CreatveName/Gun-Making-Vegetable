using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorBlockers : MonoBehaviour
{
    [SerializeField]private GameObject tutorialDoor, forestDoor;
    [SerializeField]private bool tutorialBlocker = false;
    [SerializeField]private bool closeForest = false;

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.tag == "Player" && tutorialBlocker)
        {
            tutorialDoor.SetActive(false);
        }
        
    }

    private void OnTriggerExit2D(Collider2D other) 
    {
        if(other.gameObject.tag == "Player" && closeForest)
        {
            forestDoor.SetActive(true);
        }
    }
}
