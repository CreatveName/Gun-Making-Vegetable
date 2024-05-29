using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCollisions : MonoBehaviour
{
    public bool onSell = false;//MAKE BETTER LATER AM TIRED.............
    public bool onUpgrade = false;
    [SerializeField]private Sprite NPCPic;
    [SerializeField]private Image img;

    private void OnTriggerEnter2D(Collider2D other) 
    {

        if(other.gameObject.tag == "Sell")
        {
            onSell = true;
        }
        if(other.gameObject.tag == "Upgrade")
        {
            onUpgrade = true;
        }
        if(other.gameObject.tag == "NPC")
        {
            NPCPic = other.gameObject.GetComponent<NPCCheck>().image;
            img.sprite = NPCPic;
        }
    }
    private void OnTriggerExit2D(Collider2D other) 
    {

        if(other.gameObject.tag == "Sell")
        {
            onSell = false;
        }
        if(other.gameObject.tag == "Upgrade")
        {
            onUpgrade = false;
        }
    }
}
