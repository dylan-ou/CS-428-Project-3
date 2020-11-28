using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlLights : MonoBehaviour
{
    public Light[] roomLights;
    public Light partyLight;

    Color[] colors = { Color.blue, Color.red, Color.green, Color.yellow };

    public float waitTime = 2.0f;

    private IEnumerator coroutine;
    bool partyTime = false;

    public void press()
    {
        if (!partyTime)
        {
            buttonOnPress();
        } else
        {
            buttonOffPress();
        }
    }

    void buttonOnPress()
    {
        partyTime = true;

        for(int i = 0; i < roomLights.Length; i++)
        {
            roomLights[i].intensity = 0.5f;
        }

        coroutine = partyLightColors(waitTime);
        StartCoroutine(coroutine);
        
    }

    private IEnumerator partyLightColors(float waitTime)
    {
        while (partyTime)
        {
            for (int i = 0; i < colors.Length; i++)
            {
                if (partyTime)
                {
                    for (int j = 0; j < roomLights.Length; j++)
                    {
                        roomLights[j].color = colors[i];
                    }
                }
                yield return new WaitForSeconds(waitTime);
            }
        }
    }

    void buttonOffPress()
    {
        partyTime = false;

        for (int i = 0; i < roomLights.Length; i++)
        {
            roomLights[i].intensity = 1.5f;
            roomLights[i].color = Color.white;
        }

    }
}
