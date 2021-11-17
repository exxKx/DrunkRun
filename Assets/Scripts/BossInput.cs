using UnityEngine;

public class BossInput : MonoBehaviour
{
    void Update()
    {
        if (Input.acceleration.x < -0.4 && gameObject.transform.position.x > 673.4)
        {
            transform.position =
                new Vector3(transform.position.x - 0.02f, transform.position.y, transform.position.z);
        }

        if (Input.acceleration.x > 0.4 && gameObject.transform.position.x < 681.7)
        {
            transform.position =
                new Vector3(transform.position.x + 0.02f, transform.position.y, transform.position.z);
        }
    }
}