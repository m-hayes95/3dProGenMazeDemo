using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float playerSpeed = 5f;



    private void Update()
    {
        // Add horizontal and vertical inputs to local variables.
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        // Use x and z axis inputs and assign them to a new vector 3 for movement.
        Vector3 moveDir = new Vector3(x, 0f, z);
        // Use the translate method to move the game object, indepentantly from frame rate
        transform.Translate(moveDir * playerSpeed * Time.deltaTime);
    }
}   
