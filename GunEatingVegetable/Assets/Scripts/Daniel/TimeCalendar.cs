using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class TimeCalendar : MonoBehaviour
{
    const float TIME_RATIO = 7200; //Lower timescale as game scope increases

    private int currentDay;
    private int dayOfWeek;
    private String[] weekdayName = new string[4] { "Pleunday", "Tebogoday", "Ucheday", "Flannday" };
    private float startingTime;
    private float currentTime;

    [SerializeField] private TMP_Text calendar;
    [SerializeField] private TMP_Text clock;

    // Start is called before the first frame update
    private void Start()
    {
        currentDay = 1;
        dayOfWeek = 0;
        startingTime = Time.time;
    }

    // Update is called once per frame
    private void Update()
    {
        currentTime = Time.time - startingTime; //Probably inefficient, maybe change later

        if(dayOfWeek > 3)
        {
            dayOfWeek = 0;
        }

        calendar.text = "Day: " + currentDay + " | " + weekdayName[dayOfWeek];
        clock.text = "Time: " + getCurrentTimeFormat();
    }

    private String getCurrentTimeFormat()
    {
        double scaledSecondsPassed = (currentTime * TIME_RATIO) % 86400;

        if(scaledSecondsPassed % 86400 == 0 && scaledSecondsPassed != 0)
        {
            dayOfWeek++;
            currentDay++;
        }

        int currentTimeHours = (int)Math.Floor(scaledSecondsPassed / 3600);
        int currentTimeMinutes = (int)Math.Floor((scaledSecondsPassed % 3600) / 60);

        return currentTimeHours + ":" + currentTimeMinutes;
    }


}
