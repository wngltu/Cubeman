using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10f;
    public Rigidbody rb;

    void Awake()
    {
        Destroy(gameObject, 1.0f);
    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
