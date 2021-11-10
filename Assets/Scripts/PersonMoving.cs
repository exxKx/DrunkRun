using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonMoving : MonoBehaviour
{
    private float speed = 0.01f;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        move(gameObject);
    }

  

    void move(GameObject gameObject)
    {
        gameObject.transform.position = new Vector3(
            gameObject.transform.position.x,
            gameObject.transform.position.y,
            gameObject.transform.position.z - speed);
    }
}