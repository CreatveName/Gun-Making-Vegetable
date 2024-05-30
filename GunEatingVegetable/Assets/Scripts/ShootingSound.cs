using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingSound : MonoBehaviour
{
    public AudioSource ShootSound;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ShootSound.Play();
        }
    }
}
