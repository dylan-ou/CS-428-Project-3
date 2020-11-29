using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeActiveState : MonoBehaviour
{
    public void changeState()
    {
        bool newState = !this.gameObject.activeSelf;
        this.gameObject.SetActive(newState);
    }
}
