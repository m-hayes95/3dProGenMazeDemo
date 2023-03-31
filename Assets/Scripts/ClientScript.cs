using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class ClientScript : MonoBehaviour
{
    public MeshGeneratorLand meshGeneratorLand;
    // Threshold value to compare agains mesh generators value.
    private float greenValueThreshold = 0.7f, perlinNoiseThreshold = 8f;
    // Check if values generated are over the client's threshold.
    public bool isGreenValueOverThreshold;
    public bool isPerlinNoiseValueOverThreshold;

    // List to add random client names.
    private List<string> chosenClientNames = new List<string>();
    // List of potential client names.
    private string[] potentialClientFirstNames;
    private string[] potentialClientLastNames;
    // Generated clients.
    public string clientOne;
    public string clientTwo;
    
    // Clients green value (Terrain) preference (0 = Dislikes, 1 = Likes).
    public int clientOneGreenPreference;
    public int clientTwoGreenPreference;
    

    // Clients perlin noise value (Terrain height) preference (0 = Dislikes, 1 = Likes).
    public int clientOneHeightPreference;
    public int clientTwoHeightPreference;
    

    private void Start()
    {
        // Array of fist names.
        potentialClientFirstNames = new string[10];
        potentialClientFirstNames[0] = "Tifa ";
        potentialClientFirstNames[1] = "Leon ";
        potentialClientFirstNames[2] = "Aerith ";
        potentialClientFirstNames[3] = "Ethan ";
        potentialClientFirstNames[4] = "Ada ";
        potentialClientFirstNames[5] = "Chris ";
        potentialClientFirstNames[6] = "Zack ";
        potentialClientFirstNames[7] = "Jill ";
        potentialClientFirstNames[8] = "Barret ";
        potentialClientFirstNames[9] = "Yuffie ";
        // Array of last names.
        potentialClientLastNames= new string[10];
        potentialClientLastNames[0] = "Lockheart";
        potentialClientLastNames[1] = "Kennedy";
        potentialClientLastNames[2] = "Gainsborough";
        potentialClientLastNames[3] = "Winters";
        potentialClientLastNames[4] = "Wong";
        potentialClientLastNames[5] = "Redfield";
        potentialClientLastNames[6] = "Fair";
        potentialClientLastNames[7] = "Valentine";
        potentialClientLastNames[8] = "Wallace ";
        potentialClientLastNames[9] = "Kisaragi";
        // Generate random preferences with random likes.
        GenerateClients();
        ClientsLikes();
    }

    private void Update()
    {
        
        if (meshGeneratorLand.greenValue > greenValueThreshold) 
        {
            // Set green value is above threshold bool to true.
            Debug.Log("Green Vlaue is high" );
            isGreenValueOverThreshold= true;
        }
        else isGreenValueOverThreshold = false;

        if (meshGeneratorLand.perlinNoiseResultMultiplier > perlinNoiseThreshold) 
        {
            // Set perlin value is above threshold bool to true.
            Debug.Log("Perlin noise value is high");
            isPerlinNoiseValueOverThreshold= true;
        } 
        else isPerlinNoiseValueOverThreshold= false;

    }

    private void GenerateClients()
    {
        // Client one's name.
        // Pick a random first and last name from the name arrays.
        int randomFirstName1 = Random.Range(0, potentialClientFirstNames.Length);
        int randomLastName1 = Random.Range(0, potentialClientLastNames.Length);
        // Add the randomly chosen first and last names, then add it to a new variable for the client.
        clientOne = potentialClientFirstNames[randomFirstName1] + potentialClientLastNames[randomLastName1];
        Debug.Log(clientOne); // Show client name.
        // Client twos name.
        int randomFirstName2 = Random.Range(0, potentialClientFirstNames.Length);
        int randomLastName2 = Random.Range(0, potentialClientLastNames.Length);
        clientTwo = potentialClientFirstNames[randomFirstName2] + potentialClientLastNames[randomLastName2];
        Debug.Log(clientTwo);
        

    } 

    private void ClientsLikes()
    {
        // Choose a random preference for green or high terrain,
        // then assign them to each clients current preferecne.
        clientOneGreenPreference = Random.Range(0, 2);
        clientOneHeightPreference = Random.Range(0, 2);
        clientTwoGreenPreference = Random.Range(0, 2);
        clientTwoHeightPreference = Random.Range(0, 2);
        
    }
}
