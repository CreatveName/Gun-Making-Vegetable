using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorWarp : MonoBehaviour
{
    public GameObject warpTarget;
    //Use input direction from Movement to determine player offset upon warping
    [SerializeField] private Movement movement;
    private Vector3 offset;

    [SerializeField] private bool recentWarp = true; //Temporary fix to prevent doors from unintended teleporting

    private void OnTriggerEnter2D(Collider2D other)
    {
        offset = new Vector3(movement.returnDirection().x, movement.returnDirection().y, 0);

        if(other.CompareTag("Player") && recentWarp)
        {
            other.gameObject.transform.position = warpTarget.transform.position + offset;
            warpTarget.GetComponent<DoorWarp>().recentWarp = false;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            recentWarp = true;
        }
    }

}
