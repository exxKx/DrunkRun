using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class BuffsSpawner : MonoBehaviour
{
    public bool spawn = true;
    public List<GameObject> buffs;

    private void Update()
    {
        if (spawn)
        {
            spawn = false;
            Invoke(nameof(SpawnBuff), Random.Range(2, 4));
        }
    }

    private void SpawnBuff()
    {
        spawn = true;
        GameObject car = Instantiate(buffs[Random.Range(0, buffs.Count)]);
        car.transform.position = new Vector3(Random.Range(674f, 680f),294.2339f, -240f);
        car.transform.rotation = new Quaternion(0f, 180f, 0f, 0f);
        // car.transform.localScale = new Vector3(2f, 2f, 2f);
    }
}