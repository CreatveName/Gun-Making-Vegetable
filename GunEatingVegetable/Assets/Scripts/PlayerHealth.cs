using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int playerHP;
    public int maxHP;
    public int knockbackForce;
    public Rigidbody2D player;
    private Vector3 moveDir;
    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite empyHeart;

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

        if(maxHP > playerHP)
        {
            maxHP = playerHP;
        }

        for(int i = 0; i < hearts.Length; i++)
        {
            if(i < playerHP)
            {
                hearts[i].sprite = fullHeart;
            }else
            {
                hearts[i].sprite = empyHeart;
            }

            if(i < maxHP)
            {
                hearts[i].enabled = true;
            } else
            {
                hearts[i].enabled = false;
            }
        }
    }

    private void Dead()
    {
        Destroy(gameObject);
    }
}
