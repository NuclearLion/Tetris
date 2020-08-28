using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeSpawner : MonoBehaviour
{
    public GameObject[] shapes;

    public GameObject[] nextShapes;

    GameObject upNextObject = null;

    int shapeIndex = 0;
    int nextShapeIndex = 0;

    public void SpawnShape()
    {
        int shapeIndex = nextShapeIndex;

        Instantiate(shapes[shapeIndex], transform.position, Quaternion.identity);

        nextShapeIndex = Random.Range(0, 7);

        Vector3 nextShapePosition = new Vector3(-13, 14, 250);

        if (upNextObject != null)
            Destroy(upNextObject);

        upNextObject = Instantiate(nextShapes[nextShapeIndex], nextShapePosition, Quaternion.identity);
    }

    void Start()
    {
        nextShapeIndex = Random.Range(0, 7);

        SpawnShape();
    }

}
