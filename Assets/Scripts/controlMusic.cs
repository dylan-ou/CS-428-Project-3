using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlMusic : MonoBehaviour
{
    public GameObject[] speakers;

    AudioSource[] audioSources;

    private void Start()
    {
        audioSources = new AudioSource[speakers.Length];

        for(int i = 0; i < speakers.Length; i++)
        {
            audioSources[i] = speakers[i].GetComponent<AudioSource>();
        }
    }

    public void onPress()
    {
        for(int i = 0; i < audioSources.Length; i++)
        {
            if (!audioSources[i].isPlaying)
            {
                audioSources[i].Play();
            }
            else
            {
                audioSources[i].Stop();
            }
        }
    }
}
