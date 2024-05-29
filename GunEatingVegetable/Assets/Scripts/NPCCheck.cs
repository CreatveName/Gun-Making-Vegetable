using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCCheck : MonoBehaviour
{
    [SerializeField]private GameObject playerNear;
    [SerializeField]private GameObject alert;
    public Sprite image;
    private bool isOn = false;
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.tag == "Player")
        {
            playerNear.SetActive(true);
            isOn = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other) 
    {
        if(other.gameObject.tag == "Player")
        {
            playerNear.SetActive(false);
            isOn = false;
        }
    }

    private void Update() 
    {
        if(Input.GetKeyDown(KeyCode.E) && isOn)
        {
            alert.SetActive(false);
        }

    }
}
