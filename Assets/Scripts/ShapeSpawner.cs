using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeSpawner : MonoBehaviour
{
    public GameObject[] shapes;

    public void SpawnShape()
    {
        int shapeIndex = Random.Range(0, 7);

        Instantiate(shapes[shapeIndex], transform.position, Quaternion.identity);

    }

    void Start()
    {
        SpawnShape();
    }

}
