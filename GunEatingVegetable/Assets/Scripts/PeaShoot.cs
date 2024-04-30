using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeaShoot : MonoBehaviour
{
    public GameObject bulletPre;
    public float bulletSpeed;
    private float lastFire;
    public float fireDelay;
    private float shootHor;
    public float shootVer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        shootHor = Input.GetAxis("ShootHorizontal");
        shootVer = Input.GetAxis("ShootVertical");
        PewPew();
    }

    void PewPew()
    {
        if((shootHor != 0 || shootVer != 0) && Time.time > lastFire + fireDelay)
        {
            CreateBullet(new Vector3(5f, 0f, 0f));
            CreateBullet(new Vector3(0f, 0f, 0f));
            CreateBullet(new Vector3(-5f, 0f, 0f));

            lastFire = Time.time;
        }
    }

    void CreateBullet(Vector3 offsetRotation)
    {
        GameObject bulletClone = Instantiate(bulletPre, transform.position, transform.rotation) as GameObject;
        bulletClone.transform.Rotate(offsetRotation);
        Destroy(bulletClone, 1f);
    }
}
