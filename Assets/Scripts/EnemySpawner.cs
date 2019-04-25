using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public Transform Enemy;
    public GameObject whereToSpawn;
    public int NumberToSpawn;
    public float Delay;

    void Start()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            StartCoroutine(SpawnTime());
        }
    }

    IEnumerator SpawnTime()
    {

        for (int i = 0; i < NumberToSpawn; i++)
        {
            yield return new WaitForSeconds(Delay);
            SpawnEnemy();
        }

        yield break;
    }

    void SpawnEnemy()
    {

        Instantiate(Enemy, whereToSpawn.transform.position, whereToSpawn.transform.rotation);
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Destroy(gameObject, NumberToSpawn);
            Destroy(whereToSpawn, NumberToSpawn);
        }
    }
}