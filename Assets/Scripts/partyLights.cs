using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class partyLights : MonoBehaviour
{
    public GameObject[] arrayOfPartyLights;

    public bool isOn = false;

    public void turnOnLights()
    {
        if (!isOn)
        {
            isOn = true;
            for (int i = 0; i < arrayOfPartyLights.Length; i++)
            {
                arrayOfPartyLights[i].SetActive(isOn);
            }
            
        } else
        {
            isOn = false;
            for (int i = 0; i < arrayOfPartyLights.Length; i++)
            {
                arrayOfPartyLights[i].SetActive(isOn);
            }
        }
    }

    
}
