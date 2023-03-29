using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateButton : MonoBehaviour
{
    public MeshGeneratorGrass meshGeneratorGrass;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            meshGeneratorGrass.ReGenerateMesh();
        }
        
    }
}
