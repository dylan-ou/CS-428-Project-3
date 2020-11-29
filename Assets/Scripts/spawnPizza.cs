using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnPizza : MonoBehaviour
{
    public GameObject pizza;
    public GameObject spawner;

    public int numberOfPizzas = 5;
    public float delayTime = 1f;

    public void spawnThePizza()
    {
        StartCoroutine(delay());
    }

    public IEnumerator delay()
    {
        for (int i = 0; i < numberOfPizzas; i++)
        {
            GameObject newPizza = GameObject.Instantiate(pizza, spawner.transform.position, spawner.transform.rotation) as GameObject;
            yield return new WaitForSeconds(delayTime);
        }
    }
}
