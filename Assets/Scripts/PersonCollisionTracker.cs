using UnityEngine;

public class PersonCollisionTracker : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "buff")
        {
            
        }
        
        Destroy(other.gameObject);
    }
}