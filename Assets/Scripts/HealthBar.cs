using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    TextMesh tm;
    // Start is called before the first frame update
    void Start()
    {
        tm = GetComponent<TextMesh>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.forward = Camera.main.transform.forward;
    }
    
    //TODO: Tells current health (length)
    public int current()
    {
        return 0;
    }

    //TODO: Decrease the current Health by removing one '-'
    public void decrease()
    {
        
    }
}
