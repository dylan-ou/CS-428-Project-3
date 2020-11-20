using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class partyButtonActivate : MonoBehaviour
{

    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void button1PressOn()
    {
        animator.SetBool("button1", true);
    }

    public void button1PressOff()
    {
        animator.SetBool("button1", false);
    }

    public void button2PressOn()
    {
        animator.SetBool("button2", true);
    }

    public void button2PressOff()
    {
        animator.SetBool("button2", false);
    }
}
