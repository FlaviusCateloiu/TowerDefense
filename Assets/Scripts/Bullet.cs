using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Transform target;
    public float speed = 10;
    // Start is called before the first frame update
    void FixedUpdate()
    {
        if (target)
        {
            Vector3 dir = target.position - transform.position;
            GetComponent<Rigidbody>().velocity = dir.normalized * speed;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        HealthBar health = other.GetComponentInChildren<HealthBar>();
        if (health) {
            health.Decrease();
            Destroy(gameObject);
        }
    }
}
