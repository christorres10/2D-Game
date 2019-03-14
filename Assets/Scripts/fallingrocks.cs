using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallingrocks : MonoBehaviour
{
    public int speed;

    void Start()
    {
        speed = Random.Range(5, 15);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * Time.deltaTime * speed);
        if (transform.position.y < -17)
        {
            float randomNumber = Random.Range(-10f, 13f);
            Vector3 newPos = new Vector3(randomNumber, 10, 0);
            transform.position = newPos;
            speed = Random.Range(5, 15);
        }
    }
}
