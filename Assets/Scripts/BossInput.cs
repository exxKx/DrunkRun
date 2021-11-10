using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossInput : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.acceleration.x < - 0.4)
        {
            transform.position = new Vector3(transform.position.x - 0.02f, transform.position.y, transform.position.z);
        }
        
        if (Input.acceleration.x >  0.4)
        {
            transform.position = new Vector3(transform.position.x + 0.02f, transform.position.y, transform.position.z);
        }
    }
}
