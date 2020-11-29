using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlAudio : MonoBehaviour
{
    Animator animator;
    AudioSource audioSource;

    private IEnumerator coroutine;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }

    public void startAudio()
    {
        coroutine = playSoundAndAnimation();
        StartCoroutine(coroutine);
    }

    private IEnumerator playSoundAndAnimation()
    {
        if (!audioSource.isPlaying)
            audioSource.Play();
        animator.SetBool("isNear", true);
        yield return new WaitForSeconds(1.0f);
        animator.SetBool("isNear", false);
    }
}
