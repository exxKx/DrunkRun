using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class CarSpawner : MonoBehaviour
{
    public bool spawn = true;
    public List<GameObject> cars;

    private void Update()
    {
        if (spawn)
        {
            spawn = false;
            Invoke(nameof(SpawnCar), 5);
        }
    }

    private void SpawnCar()
    {
        spawn = true;
        GameObject car = Instantiate(cars[Random.Range(0, cars.Count)]);
        car.transform.position = new Vector3(Random.Range(674f, 680f),294.2339f, -160f);
        car.transform.rotation = new Quaternion(0f, 180f, 0f, 0f);
        car.transform.localScale = new Vector3(2f, 2f, 2f);
    }
}
