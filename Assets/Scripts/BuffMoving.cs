using System;
using UnityEngine;

public class BuffMoving : MonoBehaviour
{
    private void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + PersonMoving.speed);
    }
}