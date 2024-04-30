using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bulletPre;
    public float bulletSpeed;
    private float lastFire;
    public float fireDelay;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float shootHor = Input.GetAxis("ShootHorizontal");
        float shootVer = Input.GetAxis("ShootVertical");
        if((shootHor != 0 || shootVer != 0) && Time.time > lastFire + fireDelay)
        {
            PewPew(shootHor, shootVer);
            lastFire = Time.time;
        }
    }

    void PewPew(float x, float y)
    {
        GameObject bullet = Instantiate(bulletPre, transform.position, transform.rotation) as GameObject;
        bullet.GetComponent<Rigidbody2D>().velocity = new Vector3(
            (x < 0) ? Mathf.Floor(x) * bulletSpeed : Mathf.Ceil(x) * bulletSpeed,
            (y < 0) ? Mathf.Floor(y) * bulletSpeed : Mathf.Ceil(y) * bulletSpeed,
            0
        );//CREATING CONSTANT SPEED FOR OUR BULLETS...
    }
}
