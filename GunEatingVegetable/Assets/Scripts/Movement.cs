using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    //public int playerNumber = 1; //If we want multiplayer, not rly needed
    public float moveSpeed;
    private Vector2 movement;
    [SerializeField]
    private Rigidbody2D player;
    private string hAxis;
    private string vAxis;
    private bool isRunning;


    void Start() //Setup Local Multiplayer controls by getting rid of comment + adding in multiple inputs in the unity editor...
    {
        hAxis = "Horizontal"; //+ playerNumber;
        vAxis = "Vertical"; //+ playerNumber;
    }
    private void Awake() //Turn on if we want running
    {
        //isRunning = true;
    }
    // Tracks the players X and Y values and updates it constantly.
    void Update() //Tracks input from the different axis into a variable
    {
        movement.x = Input.GetAxisRaw(hAxis);
        movement.y = Input.GetAxisRaw(vAxis);
        /*                                                          Running code
        if(Input.GetKeyDown(KeyCode.LeftShift) && isRunning)
        {
            moveSpeed = moveSpeed/3;
            isRunning = false;
        }
        else if(Input.GetKeyUp(KeyCode.LeftShift))
        {
            isRunning = true;
            moveSpeed = charStats.moveSpeed;
        }
        */
    }
    // With the new location of X and Y it allows the character to move based off of it's base movespeed.   
    private void FixedUpdate() //Physics based movement with inputs * by moveSpeed variable
    {
        player.AddForce(new Vector2(movement.x, movement.y) * moveSpeed, ForceMode2D.Force);
    }

    public Vector2 returnDirection()
    {
        return movement;
    }
}
