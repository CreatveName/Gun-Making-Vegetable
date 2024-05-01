using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Quota : MonoBehaviour
{
    [SerializeField] private GameObject endScreen;
    public Money money;
    
    public int totalDebt; //Full debt the player must pay off, ONLY INCREASES
    [SerializeField] private int startingDebt; //Initial debt the player must pay off at the start of the game
    public int paidDebt; //Debt the player has paid off

    [SerializeField] private TMP_Text debtCounter;

    // Start is called before the first frame update
    private void Start()
    {
        totalDebt = startingDebt;
        endScreen.SetActive(false);
    }

    // Update is called once per frame
    private void Update()
    {
        if(paidDebt < totalDebt)
        {
            debtCounter.text = "Debt: " + paidDebt + " / " + totalDebt;
        }
        else
        {
            debtCounter.text = "Debt paid"; //Probably replace with something more dynamic in the future
            EndGame();
        }
    }

    void EndGame()//TEMPORARY
    {
        endScreen.SetActive(true);
    }

    public void payOff(int payment)
    {
        money.currentMoney += payment; //IMPORTANT: CHANGE TO SUBTRACT MONEY IN THE FUTURE, HAVE A MENU TO USE MONEY TO PAY OFF DEBT
        paidDebt += payment;
    }

}
