using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Spawner : MonoBehaviour
{
    public GameObject myPrefab;
    private float time;
    private GameObject instantiatedObj;
    System.Random rand = new System.Random();
    // Start is called before the first frame update
    void Start()
    {
        time = 10;
        InvokeRepeating("LaunchProjectile", 2.0f, 1.3f);
    }

    // Update is called once per frame
    void FixedUpdate()
    {

       
    }

    void LaunchProjectile()
    {
        instantiatedObj = (GameObject)Instantiate(myPrefab, new Vector3(rand.Next(-20, 20), rand.Next(20), rand.Next(-20, 20)), Quaternion.identity);
        Destroy(instantiatedObj, time);
    }
}
