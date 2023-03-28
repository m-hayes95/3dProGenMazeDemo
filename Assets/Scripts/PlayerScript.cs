using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float playerSpeed = 5f;
    

    private void Update()
    {
        float moveDirZ = Input.GetAxis("Horizontal");
        float moveDirX = Input.GetAxis("Vertical");
        Vector3 moveDir = new Vector3 (-moveDirX, 0f, moveDirZ);
        transform.Translate(moveDir * playerSpeed * Time.deltaTime);
    }
}
