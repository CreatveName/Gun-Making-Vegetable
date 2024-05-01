using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeaShoot : MonoBehaviour
{
    public GameObject bulletPre;
    public float bulletSpeed;
    private float lastFire;
    public float fireDelay;

    // Update is called once per frame
    void Update()
    {
        float shootHor = Input.GetAxis("ShootHorizontal");
        float shootVer = Input.GetAxis("ShootVertical");
        if((shootHor != 0 || shootVer != 0) && Time.time > lastFire + fireDelay)
        {
            PewPew(shootHor, shootVer, .8f);//GENERATE 3 BULLETS @ DIFF SPEEDS MAYBE FAN LATER IDK
            PewPew(shootHor, shootVer, .9f);
            PewPew(shootHor, shootVer, 1f);
            lastFire = Time.time;
        }
    }

    void PewPew(float x, float y, float z)
    {
        Vector3 rand = new Vector3(z, 0f, 0f);
        GameObject bullet = Instantiate(bulletPre, transform.position, transform.rotation) as GameObject;
        bullet.transform.Rotate(rand); //FAN HERE BUT VELOCITY THING CHANGES IT ANYWYAYS
        bullet.GetComponent<Rigidbody2D>().velocity = new Vector3(
            (x < 0) ? Mathf.Floor(x) * bulletSpeed * z : Mathf.Ceil(x) * bulletSpeed * z,
            (y < 0) ? Mathf.Floor(y) * bulletSpeed * z : Mathf.Ceil(y) * bulletSpeed * z,
            0
        );//CREATING CONSTANT SPEED FOR OUR BULLETS...
    }
    
}
