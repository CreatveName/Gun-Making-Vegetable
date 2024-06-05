using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseVeg : MonoBehaviour
{
    private PlayerHealth pHealth;
    private PlayerCollisions playerCollisions;
    public GameObject sellButton, upgradeButton;
    private Inventory inventory;
    [SerializeField]private bool isGinger;
    
    [SerializeField] private Quota quota;
    [SerializeField] private Birb birb;
    [SerializeField] private bool isBirb = false;
    
    private void Awake() 
    {
        pHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
        playerCollisions = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerCollisions>();
        quota = GameObject.FindGameObjectWithTag("Money").GetComponent<Quota>();
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
        if (isBirb)
        {
            birb = GameObject.FindGameObjectWithTag("Birb").GetComponent<Birb>();
        }
        
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
            if(Input.GetKeyDown(KeyCode.Q))
            {
                FeedVeggie();
            }
        }
    }
    public void EatVeggie()
    {
        if(!isGinger)
        {
            pHealth.playerHP++;
            pHealth.maxHP++;
        }else if(isGinger)
        {
            pHealth.playerHP--;
            pHealth.maxHP--;
        }
        
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
            quota.payOff(50); //integrate different vegetable costs in the future
            if(isBirb)
            {
                quota.payOff(200);
            }
            Destroy(gameObject);
        }
    }
    public void FeedVeggie()
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
            birb.birbTummy++;
            Destroy(gameObject);
        }
    }
}
