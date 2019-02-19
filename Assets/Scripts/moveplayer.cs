using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveplayer : MonoBehaviour
{
    public float inputSpeed = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("left"))
            transform.Translate
            (-inputSpeed
            * Time.deltaTime
            , 0.0f, 0.0f);
        if (Input.GetKey("up"))
            transform.Translate(0.0f, inputSpeed* Time.deltaTime, 0.0f);
        if (Input.GetKey("down"))
            transform.Translate(0.0f, -inputSpeed* Time.deltaTime, 0.0f);
    }
}
