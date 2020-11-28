using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlAudio : MonoBehaviour
{
    Animator animator;
    AudioSource audioSource;


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }

    public void startAudio()
    {
        if (!audioSource.isPlaying)
        {
            audioSource.Play();
        }
    }
}
