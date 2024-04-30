using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisions : MonoBehaviour
{
    public bool onSell = false;//MAKE BETTER LATER AM TIRED.............
    public bool onUpgrade = false;

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
