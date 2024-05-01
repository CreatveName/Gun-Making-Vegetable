using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseVeg : MonoBehaviour
{
    private PlayerHealth pHealth;
    private PlayerCollisions playerCollisions;
    public GameObject sellButton, upgradeButton;
    
    private void Awake() 
    {
        pHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
        playerCollisions = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerCollisions>();
    }
    private void Update() //FIX LATER TOO TIRED
    {
        if(playerCollisions.onSell == false)
        {
            sellButton.SetActive(false);
        }else{
            sellButton.SetActive(true);
        }
        if(playerCollisions.onUpgrade == false)
        {
            upgradeButton.SetActive(false);
        }else{
            upgradeButton.SetActive(true);
        }
    }
    public void EatVeggie()
    {
        pHealth.playerHP++;
        pHealth.maxHP++;
        Destroy(gameObject);
    }
    public void SellVeggie()
    {
        if(playerCollisions.onSell == true)
        {
            //ADD MONEY OR SOMETHING INTEGRATE WITH DANIEL CODE
            Destroy(gameObject);
        }
    }
    public void UpgradeVeggie()
    {
        if(playerCollisions.onUpgrade == true)
        {
            //UPGRADES!!!! IDK HOW YET/NEED TO CLASSIFY BUTTON
            Destroy(gameObject);
        }
    }
}
