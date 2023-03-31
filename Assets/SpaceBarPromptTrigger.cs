using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpaceBarPromptTrigger : MonoBehaviour
{
    public UIManager uIManager; // Ref to UI manager script, so we can enable and disable images.
    private const string PLAYER = "Player";

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(PLAYER)) // Check if entering collider is Player
        {
            Debug.Log("Show Space Button Prompt");
            // If player enters the trigger area, display the space bar prompt on the player screen.
            uIManager.spaceButtonPrompt.enabled = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // If player leaves the trigger area, remove the space bar prompt from the player screen.
        if (other.CompareTag(PLAYER))
        {
            uIManager.spaceButtonPrompt.enabled = false;    
        }
    }
}
