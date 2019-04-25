using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeriodicSpawner : MonoBehaviour
{
    public float frequency = 0.5f; // every half second

    private void OnEnable()
    {
        StartCoroutine(Spawn());
    }

    private void OnDisable()
    {
        StopAllCoroutines();
    }

    private IEnumerator Spawn()
    {
        WaitForSeconds delay = new WaitForSeconds(frequency);

        while (true)
        {
            yield return delay;

            // spawn your objects
        }
    }
}
