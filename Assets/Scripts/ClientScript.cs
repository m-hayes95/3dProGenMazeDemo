using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class ClientScript : MonoBehaviour
{
    public MeshGeneratorGrass meshGeneratorGrass;
    // Threshold value to compare agains mesh generators value.
    private float greenValueThreshold = 0.7f, perlinNoiseThreshold = 8f;
    [SerializeField]
    private bool isGreenValueOverThreshold;
    [SerializeField]
    private bool isPerlinNoiseValueOverThreshold;

    // List to add random client names.
    private List<string> chosenClientNames = new List<string>();
    // List of potential client names.
    private string[] potentialClientFirstNames;
    private string[] potentialClientLastNames;
    // Generated clients.
    public string clientOne;
    public string clientTwo;
    public string clientThree;
    // Clients green value (Terrain) preference (0 = Dislikes, 1 = Likes).
    public int clientOneGreenPreference;
    public int clientTwoGreenPreference;
    public int clientThreeGreenPreference;

    // Clients perlin noise value (Terrain height) preference (0 = Dislikes, 1 = Likes).
    public int clientOneHeightPreference;
    public int clientTwoHeightPreference;
    public int clientThreeHeightPreference;

    // Client wants higher mountain view - Mesh Height over ...
    // Client wants flater mountain view - Mesh Low under ... 
    // Client wants bright green view - Green value over ... 
    // Client wants dark green view - Green value under ...
    private void Start()
    {
        // Array of fist names
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
        // Array of last names
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

        GenerateClients();
        ClientsLikes();
    }

    private void Update()
    {
        
        if (meshGeneratorGrass.greenValue > greenValueThreshold) 
        {
            // Set green value is above threshold bool to true.
            Debug.Log("Green Vlaue is high" );
            isGreenValueOverThreshold= true;
        }
        else isGreenValueOverThreshold = false;

        if (meshGeneratorGrass.perlinNoiseResultMultiplier > perlinNoiseThreshold) 
        {
            // Set perlin value is above threshold bool to true.
            Debug.Log("Perlin noise value is high");
            isPerlinNoiseValueOverThreshold= true;
        } 
        else isPerlinNoiseValueOverThreshold= false;

    }

    private void GenerateClients()
    {
        int randomFirstName1 = Random.Range(0, potentialClientFirstNames.Length);
        int randomLastName1 = Random.Range(0, potentialClientLastNames.Length);
        clientOne = potentialClientFirstNames[randomFirstName1] + potentialClientLastNames[randomLastName1];
        Debug.Log(clientOne);
        int randomFirstName2 = Random.Range(0, potentialClientFirstNames.Length);
        int randomLastName2 = Random.Range(0, potentialClientLastNames.Length);
        clientTwo = potentialClientFirstNames[randomFirstName2] + potentialClientLastNames[randomLastName2];
        Debug.Log(clientTwo);
        int randomFirstName3 = Random.Range(0, potentialClientFirstNames.Length);
        int randomLastName3 = Random.Range(0, potentialClientLastNames.Length);
        clientThree = potentialClientFirstNames[randomFirstName3] + potentialClientLastNames[randomLastName3];
        Debug.Log(clientThree);

    } 

    private void ClientsLikes()
    {
        
        clientOneGreenPreference = Random.Range(0, 2);
        clientOneHeightPreference = Random.Range(0, 2);
        clientTwoGreenPreference = Random.Range(0, 2);
        clientTwoHeightPreference = Random.Range(0, 2);
        clientThreeGreenPreference = Random.Range(0, 2);
        clientThreeHeightPreference = Random.Range(0, 2);
    }
}
