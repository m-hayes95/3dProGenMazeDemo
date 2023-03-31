using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Ref to client script.
    public ClientScript clientScript;
    // Check if clients green and height values have been met.
    private bool clientOneGreenIsOk = false, clientTwoGreenIsOk = false, clientThreeGreenIsOk = false;
    private bool clientOneHeightIsOk = false, clientTwoHeightIsOk = false, clientThreeHeightIsOk = false;

    private void Update()
    {
        CheckIfClientsPreferencesHaveBeenMet();
    }

    private void CheckIfClientsPreferencesHaveBeenMet()
    {
        // Check if Client one has high green preference and the green vlaue is over the threshold.
        if (clientScript.isGreenValueOverThreshold == true && clientScript.clientOneGreenPreference == 1)
        {
            clientOneGreenIsOk = true; // If both return true, set green is okay bool to true for client 1.
        }
        else clientOneGreenIsOk = false; // If both return fasle, set green is okay bool to false for client 1.
        // Client 2 green pref check.
        if (clientScript.isGreenValueOverThreshold == true && clientScript.clientTwoGreenPreference == 1)
        {
            clientTwoGreenIsOk = true;
        }
        else clientTwoGreenIsOk = false;
        // Client 3 green pref check.
        if (clientScript.isGreenValueOverThreshold == true && clientScript.clientThreeGreenPreference == 1)
        {
            clientThreeGreenIsOk = true;
        }
        else clientThreeGreenIsOk = false;

        // Check if Client one has high height preference and the height value from perlin noise is over the threshold.
        if (clientScript.isPerlinNoiseValueOverThreshold == true && clientScript.clientOneHeightPreference == 1)
        {
            clientOneHeightIsOk = true; // If both return true, set height is okay bool to true for client 1.
        }
        else clientOneHeightIsOk = false; // If both return fasle, set height is okay bool to false for client 1.
        // Client 2 height pref check.
        if (clientScript.isPerlinNoiseValueOverThreshold == true && clientScript.clientTwoHeightPreference == 1)
        {
            clientTwoHeightIsOk = true;
        }
        else clientTwoHeightIsOk = false;
        // Client 3 height pref check.
        if (clientScript.isPerlinNoiseValueOverThreshold == true && clientScript.clientThreeHeightPreference == 1)
        {
            clientThreeHeightIsOk = true;
        }
        else clientThreeHeightIsOk = false;
    }
}
