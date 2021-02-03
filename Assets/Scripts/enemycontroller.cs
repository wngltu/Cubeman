using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemycontroller: MonoBehaviour
{
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("pbullet"))
        {
            Destroy(gameObject);
        }
    }

}
