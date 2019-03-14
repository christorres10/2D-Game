using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aliencollide : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "player")
        {
            Destroy(col.gameObject);
        }
    }
}
