using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeGenerator : MonoBehaviour
{
    public GameObject mazeWallPrefab;
    public int mazeSize = 15;
    public float perlineThreshold = 0.5f;
    public float startPointThreshold = 0.1f;
    public float endPointThreshold = 0.9f;

    private GameObject mazeStartPoint, mazeEndPoint;

    private void Start()
    {
        for (int x = 0; x < mazeSize; x++)
        {
            for (int y = 0; y < mazeSize; y++)
            {
                float perlinValue = Mathf.PerlinNoise(x / (float)mazeSize, y / (float)mazeSize);
                if (perlinValue < 0.185 || perlinValue > 0.56)
                {
                    Debug.Log(perlinValue);
                }
                

                if (perlinValue < perlineThreshold)
                {
                    GameObject newMazeWall = Instantiate(mazeWallPrefab, new Vector3(x, 0, y), Quaternion.identity);
                    newMazeWall.transform.parent = transform;
                }

                if (perlinValue < startPointThreshold && mazeStartPoint == null) // Create start point of maze
                {
                    Debug.Log(perlinValue - startPointThreshold + " Spawn start point " + perlinValue);
                    mazeStartPoint = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                    mazeStartPoint.transform.position = new Vector3(x, 0.5f, y);
                    mazeStartPoint.transform.parent = transform;
                }

                if (perlinValue > endPointThreshold && mazeEndPoint == null) // Create end point of maze
                {
                    Debug.Log(perlinValue - endPointThreshold + " Spawn end point " + perlinValue);
                    mazeEndPoint = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
                    mazeEndPoint.transform.position = new Vector3(x, 0.5f, y);
                    mazeEndPoint.transform.parent = transform;
                } 
            }
        }
    }
}
