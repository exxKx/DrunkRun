using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PersonCollisionTracker : MonoBehaviour
{
    private GameObject camera;
    
    private void Start()
    {
        camera = GameObject.Find("Main Camera");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Drink")
        {
            camera.GetComponent<Animator>().speed += 1.5f;
        }
        if (other.tag == "Food")
        {
            camera.GetComponent<Animator>().speed -= 1;
        }
        
        if (other.tag == "Car")
        {
            ScoreManager.finishScore();
            SceneManager.LoadScene("MenuScene");
        }

        if (other.tag != "Player")
        {
            Destroy(other.gameObject);
        }
    }
}