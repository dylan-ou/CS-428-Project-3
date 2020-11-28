using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlScreen : MonoBehaviour
{
    public GameObject gifs;

    bool gifOn = false;

    public void changeCurrentState()
    {
        gifOn = !gifOn;
        gifs.SetActive(gifOn);
    }
}
