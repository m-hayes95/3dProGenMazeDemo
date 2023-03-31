using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Runtime.CompilerServices;

public class UIManager : MonoBehaviour
{
    // Ref to client names and likes and player points.
    public ClientScript clientScript;
    public GameManager gameManager;
    // Ref to player points and client name UI text fields.
    public TextMeshProUGUI _playerPoints, client1Name, client2Name;
    // Ref to clients likes UI text fields.
    public TextMeshProUGUI client1LikesHighHills, client2LikesHighHills;
    public TextMeshProUGUI client1LikesGreenHills, client2LikesGreenHills;
    // Ref to clients dislikes UI text fields.
    public TextMeshProUGUI client1DislikesHighHills, client2DislikesHighHills;
    public TextMeshProUGUI client1DislikesGreenHills, client2DislikesGreenHills;
    // Ref to space bar button prompt.
    public Image spaceButtonPrompt;

    private void Awake()
    {
        // Spacebar prompt is enabled on button > spacebar prompt trigger scirpt.
        spaceButtonPrompt.enabled = false;
        // Set all clients likes and dislikes to disabled, controlled in client script.
        client1LikesHighHills.enabled = false;
        client1DislikesHighHills.enabled = false;
        client1LikesGreenHills.enabled = false;
        client1DislikesGreenHills.enabled = false;

        client2LikesHighHills.enabled = false;
        client2DislikesHighHills.enabled = false;
        client2LikesGreenHills.enabled = false;
        client2DislikesGreenHills.enabled = false;
    }
    private void Update()
    {
        // Update the players points, and current client names and likes / dislikes.
        _playerPoints.text = gameManager.playerPoints.ToString();
        client1Name.text = clientScript.clientOne;
        client2Name.text = clientScript.clientTwo;
    }

    
}
