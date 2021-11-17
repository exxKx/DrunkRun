using UnityEngine;

public class DestroyBuffs : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Food" || other.tag == "Drink")
        {
            Destroy(other.gameObject);   
        }
    }
}