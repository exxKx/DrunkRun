using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    private Text text; 
    
    void Start()
    {
        text = GameObject.Find("Text").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        var accelerationX = Input.acceleration.x;
        var accelerationY = Input.acceleration.y;
        var accelerationZ = Input.acceleration.z;
        
        var accelerationNX = Input.acceleration.normalized.x;
        var accelerationNY = Input.acceleration.normalized.y;
        var accelerationNZ = Input.acceleration.normalized.z;

        text.text = accelerationX +" " + accelerationY  +" " + accelerationZ + "\n" + accelerationNX  +" " + accelerationNY  +" " + accelerationNZ;
    }
}
