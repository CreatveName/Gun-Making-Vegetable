using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseVeg : MonoBehaviour
{
    private PlayerHealth pHealth;
    private PlayerCollisions playerCollisions;
    public GameObject sellButton, upgradeButton;
    private Inventory inventory;
    
    [SerializeField] private Quota quota;
    
    private void Awake() 
    {
        pHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
        playerCollisions = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerCollisions>();
        quota = GameObject.FindGameObjectWithTag("Money").GetComponent<Quota>();
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }
    private void Update() //FIX LATER TOO TIRED
    {
        if(playerCollisions.onSell == false)
        {
            sellButton.SetActive(false);
        }else{
            sellButton.SetActive(true);

            if(Input.GetKeyDown(KeyCode.Q))
            {
                SellVeggie();
            }

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
        for(int i = 0; i < inventory.slots.Length; i++)
            {
                if(inventory.isFull[i] == true)
                {
                    inventory.isFull[i] = false;
                    break;
                }
            }
        Destroy(gameObject);
    }
    public void SellVeggie()
    {
        if(playerCollisions.onSell == true)
        {
            for(int i = 0; i < inventory.slots.Length; i++)
            {
                if(inventory.isFull[i] == true)
                {
                    inventory.isFull[i] = false;
                    break;
                }
            }
            quota.payOff(20); //integrate different vegetable costs in the future
            Destroy(gameObject);
        }
    }
    public void UpgradeVeggie()
    {
        if(playerCollisions.onUpgrade == true)
        {
            for(int i = 0; i < inventory.slots.Length; i++)
            {
                if(inventory.isFull[i] == true)
                {
                    inventory.isFull[i] = false;
                    break;
                }
            }
            //UPGRADES!!!! IDK HOW YET/NEED TO CLASSIFY BUTTON
            Destroy(gameObject);
        }
    }
}
