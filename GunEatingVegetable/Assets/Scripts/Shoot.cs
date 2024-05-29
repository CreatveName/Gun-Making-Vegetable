using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bulletPre;
    public Transform bulletTrans;
    private bool canFire;
    private float timer;
    public float fireDelay;

    private Camera mainCam;
    private Vector3 mousePos;

    // Start is called before the first frame update
    void Start()
    {
        mainCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {

        mousePos = mainCam.ScreenToWorldPoint(Input.mousePosition);

        Vector3 rotation = mousePos - transform.position;

        float rotZ = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0, 0, rotZ);

        if(Input.GetMouseButton(0) && canFire)
        {
            canFire = false;
            Instantiate(bulletPre, bulletTrans.position, Quaternion.identity);
        }

        if(!canFire)
        {
            timer += Time.deltaTime;
            if(timer > fireDelay)
            {
                canFire = true;
                timer = 0;
            }
        }
    }

}
