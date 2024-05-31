using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Birb : MonoBehaviour
{

    public int birbTummy;
    [SerializeField] private GameObject truffle;

    private void Start() {
        birbTummy = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(birbTummy == 6)
        {
            SpawnTruffle();
        }
    }

    private void SpawnTruffle()
    {
        Instantiate(truffle, this.transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
