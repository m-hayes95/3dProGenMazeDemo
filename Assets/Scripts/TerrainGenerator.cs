using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainGenerator : MonoBehaviour
{
    // width, height, depth of terrain.
    public int width = 256, height = 256, depth = 20;
    // Scale of terrain and offset x and y coords.
    [SerializeField] private float scale = 20f, offsetX = 100f, offsetY = 100f;

    public void Start()
    {
        // Generate random offset on start
        //offsetX = Random.Range(0f, 9999f);
        //offsetY = Random.Range(0f, 9999f);

    }

    private void Update()
    {
        Terrain terrain = GetComponent<Terrain>(); // Define the terrain.
        // Get ref to terrain data and set it as the result of the GenerateTerrain Method.
        terrain.terrainData = GenerateTerrain(terrain.terrainData);
    }

    // Generate the terrain data.
    TerrainData GenerateTerrain(TerrainData terrainData)
    {
        // Set the heightmap resolution and size of the terrain data.
        terrainData.heightmapResolution = width + 1;
        terrainData.size = new Vector3(width, depth, height);

        // Generate the height of the terrain and set to the terrain data.
        terrainData.SetHeights(0, 0, GenerateHeights());

        // Generate the texture and set it to the terrain data.
        terrainData.baseMapResolution = width + 1;
        terrainData.alphamapResolution = width + 1;
        terrainData.SetAlphamaps(0, 0, GenerateTexture());

        return terrainData;
    }
    // Generate texture for terrain.
    float[,,] GenerateTexture()
    {
        float[,,] texture = new float[width, height, 2];

        // Loop through each x and y coord to generate the texture.
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                // Calculate x and y coord using on scale and offset value.
                float xCoord = (float)x / width * scale * offsetX;
                float yCoord = (float)y / width * scale * offsetY;

                // Generate the texture using the Perlin noise method.
                float noise = Mathf.PerlinNoise(xCoord, yCoord);

                // Set the texture bsaed on the noise value
                if (noise > 0.2f)
                {
                    texture[x, y, 0] = 1f;
                    texture[x, y, 1] = 0f;
                }
                else if (noise < 0.5f)
                {
                    texture[x, y, 0] = 0f;
                    texture[x, y, 1] = 01;
                }
                else
                {
                    texture[x, y, 0] = 1f;
                    texture[x, y, 1] = 1f;
                }
            }
        }
        return texture;
    }

    // Generate the heights of the terrain.
    float[,] GenerateHeights()
    {
        float[,] heights = new float[width, height];

        // Loop through each x and y coordinate to generate the heights.
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                float xCoord = (float)x / width * scale + offsetX;
                float yCoord = (float)y / depth * scale + offsetY;
                float sample = Mathf.PerlinNoise(xCoord, yCoord);

                heights[x, y] = sample;
            }
        }
        return heights;
    }
    // Calculate the height at the given x and y coordinate.
    /*  float CalculateHeight(int x, int y)
      {
          // Calculate the x and y coordinate based on the given scale and offset.
          float xCoord = (float)x / width * scale + offsetX;
          float yCoord = (float)y / depth * scale + offsetY;
          // Generate the height of the map using the Perlin noise method and return it.
          return Mathf.PerlinNoise(xCoord, yCoord);
      }
      // Generate the texture
      */
}
