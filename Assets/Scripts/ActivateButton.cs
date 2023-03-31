using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateButton : MonoBehaviour
{
    public MeshGeneratorLand meshGeneratorLand;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // On input, re-gen terrain.
        if (Input.GetKeyDown(KeyCode.Space))
        {
            meshGeneratorLand.ReGenerateMesh();
        }
        
    }
}
