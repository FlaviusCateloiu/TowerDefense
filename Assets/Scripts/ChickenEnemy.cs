using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject egg = GameObject.Find("egg");
        if (egg)
        {
            GetComponent<UnityEngine.AI.NavMeshAgent>().destination = egg.transform.position;
        }
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.name == "egg")
        {
            other.GetComponentInChildren<HealthBar>().Decrease();
            Destroy(gameObject);
        }
    }
}
