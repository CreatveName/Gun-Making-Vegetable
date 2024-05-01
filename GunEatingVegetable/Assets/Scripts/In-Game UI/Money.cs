using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Money : MonoBehaviour
{
    public int currentMoney;

    [SerializeField] private TMP_Text moneyCounter;

    // Start is called before the first frame update
    private void Start()
    {
        currentMoney = 0;   
    }

    private void Update()
    {
        moneyCounter.text = "Money: " + currentMoney;
    }
}
