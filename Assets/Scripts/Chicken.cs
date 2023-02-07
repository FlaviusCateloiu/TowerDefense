using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chicken : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float rotationSpeed = 35;

    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(Vector3.up * (Time.deltaTime * rotationSpeed), Space.World);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.GetComponentInChildren<ChickenEnemy>())
        {
            GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            bullet.GetComponent<Bullet>().target = other.transform;
        }
    }
}
