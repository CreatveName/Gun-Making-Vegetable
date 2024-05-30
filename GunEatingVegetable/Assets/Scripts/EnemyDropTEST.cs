using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDropTEST : MonoBehaviour
{
    public int enemyHealth;
    public int maxHP;
    public int knockbackForce;
    private Vector3 moveDir;
    public GameObject[] dropTest;
    public Rigidbody2D enemy;

    private void Start() 
    {
        enemyHealth = maxHP;
    }

    private void Update() 
    {
        if(enemyHealth <= 0)
        {
            Dead();
        }
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.tag == "Bullet")
        {
            enemyHealth -= 1;
            moveDir = enemy.transform.position - other.transform.position;
            enemy.AddForce(moveDir.normalized * -knockbackForce);
        }
    }

    private void Dead()
    {
        Instantiate(dropTest[GetRandomValue()], this.transform.position, this.transform.rotation); //RNG HARD CODED IN FOR DROPS
        Destroy(gameObject);
    }
    private int GetRandomValue()
    {
        float rand = Random.value;
        if(rand <= .4f)
            return 0;
        if(rand <= .65f)
            return 1;
        if(rand <= .85f)
            return 2;
        
        return 3;
        
    }
}
