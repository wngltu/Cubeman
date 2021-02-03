using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter2 : MonoBehaviour
{
    GameObject clone;
    public GameObject Bullet;
    float cooldown = .5f;
    float cooldowntimer = .5f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        cooldowntimer += Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.J) && cooldowntimer >= cooldown)
        {
            clone = (GameObject)Instantiate(Bullet, transform.position, Quaternion.identity);
            clone.GetComponent<Rigidbody>().velocity = new Vector3(-20, 0);
            cooldowntimer = 0;
        }
    }
}
