using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class CarSpawner : MonoBehaviour
{
    public bool spawn = true;
    public List<GameObject> cars;
    private bool left = true;

    private void Update()
    {
        if (spawn)
        {
            spawn = false;
            Invoke(nameof(SpawnCar), 2);
        }
    }

    private void SpawnCar()
    {
        float xPos = 0;
        if (left)
        {
            xPos = Random.Range(672f, 677f);
        }
        else
        {
            xPos = Random.Range(677f, 682f);
        }

        left = !left;
        spawn = true;
        GameObject car = Instantiate(cars[Random.Range(0, cars.Count)]);
        car.transform.position = new Vector3(xPos,294.2339f, -160f);
        car.transform.rotation = new Quaternion(0f, 180f, 0f, 0f);
        car.transform.localScale = new Vector3(2f, 2f, 2f);
    }
}
