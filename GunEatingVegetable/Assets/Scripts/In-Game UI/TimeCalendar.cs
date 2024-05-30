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

    [SerializeField] private TMP_Text calendar;
    [SerializeField] private GameObject dayMarkerPre;
    [SerializeField] private GameObject Spawnpoint;
    

    // Start is called before the first frame update
    private void Start()
    {
        currentDay = 1;
        dayOfWeek = 0;
    }

    // Update is called once per frame
    private void FixedUpdate()
    {

        if(dayOfWeek > 3)
        {
            dayOfWeek = 0;
        }

        calendar.text = "Day: " + currentDay + " | " + weekdayName[dayOfWeek];
    }

    public void AddDay()
    {
        dayOfWeek++;
        currentDay++;
        (Instantiate(dayMarkerPre, Spawnpoint.transform) as GameObject).transform.parent = Spawnpoint.transform;

    }

}
