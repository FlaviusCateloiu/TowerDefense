using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerLocation : MonoBehaviour
{
    public GameObject towerPrefab;
    
    // Execute when click and unclick the GameObject with the mouse.
    void OnMouseUpAsButton()
    {
        // Build Tower above TowerLocation.
        GameObject newTower = (GameObject)Instantiate(towerPrefab);
        newTower.transform.position = transform.position + Vector3.up;
    }
}
