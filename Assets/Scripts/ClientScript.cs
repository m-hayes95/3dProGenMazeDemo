using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClientScript : MonoBehaviour
{
    public MeshGeneratorGrass meshGeneratorGrass;
    private float greenValueThreshold, perlinNoiseThreshold;

    // Client wants higher mountain view - Mesh Height over ...
    // Client wants flater mountain view - Mesh Low under ... 
    // Client wants bright green view - Green value over ... 
    // Client wants dark green view - Green value under ...

    private void Update()
    {
        if (meshGeneratorGrass.greenValue == greenValueThreshold) 
        {
            // Set green value is above threshold bool to true.
        }

        if (meshGeneratorGrass.perlinNoiseResultMultiplier == perlinNoiseThreshold) 
        {
            // Set perlin value is above threshold bool to true.
        }
    }
}
