using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public float speed = 10f;
    public Rigidbody rb;

    void Awake()
    {
        Destroy(gameObject, 3f);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (!(other.gameObject.CompareTag("enemy")))
        {
            Destroy(gameObject);
        }
    }
}
