using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class hitobject : MonoBehaviour
{


   void Update()
    {
        void OnCollisionEnter(Collision c)
        {
            float force = 3;
            if (c.gameObject.name == "colorfulastroid")
            {
                Debug.Log("InCollision");
                Vector3 dir = c.contacts[0].point - transform.position;
                dir = -dir.normalized;
                GetComponent<Rigidbody>().AddForce(dir * force);
            }
        }
    }

}