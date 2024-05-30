using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bed : MonoBehaviour
{
    [SerializeField]private TimeCalendar tim;
    [SerializeField]private GameObject eThing;
    private bool onBed = false;

    private void Start() 
    {
        tim = GameObject.FindGameObjectWithTag("TimeCalendar").GetComponent<TimeCalendar>();
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.tag == "Player")
        {
            onBed = true;
            eThing.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D other) 
    {
        if(other.gameObject.tag == "Player")
        {
            onBed = false;
            eThing.SetActive(false);
        }
    }

    private void Update() 
    {
        if(onBed && Input.GetKeyDown(KeyCode.E))
        {
            tim.AddDay();
            //PROGRESS TO NEXT SCENE :)
        }
    }
}
