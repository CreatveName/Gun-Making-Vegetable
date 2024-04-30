using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int playerHP;
    public int maxHP;
    public int knockbackForce;
    public Rigidbody2D player;
    private Vector3 moveDir;

    private void Start() 
    {
        playerHP = maxHP;
    }
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.tag == "Enemy")
        {
            playerHP -= 1;
            moveDir = player.transform.position - other.transform.position;
            player.AddForce(moveDir.normalized * -knockbackForce);
        }
    }

    private void Update() 
    {
        if(playerHP <= 0)
        {
            Dead();
        }
    }

    private void Dead()
    {
        Destroy(gameObject);
    }
}
