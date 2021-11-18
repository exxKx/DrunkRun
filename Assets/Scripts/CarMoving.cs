using System;
using UnityEngine;

public class CarMoving : MonoBehaviour
{
    private float speed = 0.6f;
    private void FixedUpdate()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - speed);
    }
}