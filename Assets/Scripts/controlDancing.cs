using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlDancing : MonoBehaviour
{
    public GameObject[] people;

    Animator[] animators;

    bool isDancing = false;

    private void Start()
    {
        animators = new Animator[people.Length];

        for(int i = 0; i < people.Length; i++)
        {
            animators[i] = people[i].GetComponent<Animator>();    
        }
    }

    public void controlDance()
    {
        if (!isDancing)
        {
            for(int i = 0; i < animators.Length; i++)
            {
                animators[i].SetBool("idleToDance", true);
            }
            isDancing = true;
        } else
        {
            for (int i = 0; i < animators.Length; i++)
            {
                animators[i].SetBool("danceToIdle", true);
            }
            isDancing = false;
        }
    }

    public void resetBools()
    {
        if (!isDancing)
        {
            for (int i = 0; i < animators.Length; i++)
            {
                animators[i].SetBool("idleToDance", false);
            }
        }
        else
        {
            for (int i = 0; i < animators.Length; i++)
            {
                animators[i].SetBool("danceToIdle", false);
            }
        }
    }
}
