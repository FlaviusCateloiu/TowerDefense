using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float interval = 3;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnNext", interval, interval);
    }

    void SpawnNext()
    {
        Instantiate(enemyPrefab, transform.position, Quaternion.identity);
    }
}
