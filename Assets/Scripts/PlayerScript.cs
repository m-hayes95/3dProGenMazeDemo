using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public GameManager gameManager;
    public float playerSpeed = 5f;

    public bool viewSubmittedForClient1 = false, viewSubmittedForClient2 = false;

    private void Update()
    {
        // Add horizontal and vertical inputs to local variables.
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        // Use x and z axis inputs and assign them to a new vector 3 for movement.
        Vector3 moveDir = new Vector3(x, 0f, z);
        // Use the translate method to move the game object, indepentantly from frame rate
        transform.Translate(moveDir * playerSpeed * Time.deltaTime);

        // Submit view for client 1 on key prees.
        if (Input.GetKeyDown("1") && viewSubmittedForClient1 == false)
        {
            gameManager.SubmitViewForClientOne(); // Call the sumbit view method from the game manager script.
            viewSubmittedForClient1 = true; // Bool used to stop both methods being called at the same time.
        }

        // Submit view for client 2 after player has submitted view for client 1.
        if (Input.GetKeyDown("2") && viewSubmittedForClient1 == true && viewSubmittedForClient2 == false)
        {
            gameManager.SubmitViewForClientTwo(); // Call the sumbit view method from the game manager script.
            viewSubmittedForClient2 = true;
        }
    }
}   
