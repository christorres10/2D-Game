using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteorfall : MonoBehaviour
{
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name.Equals("player"))
            rb.isKinematic = false;
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name.Equals("player"))
            Application.LoadLevel(2);
            return;
    }
}
