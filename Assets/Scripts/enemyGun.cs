using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyGun : MonoBehaviour
{
    GameObject clone;
    GameObject clone2;
    GameObject clone3;
    GameObject clone4;
    public GameObject Bullet;
    float cooldown = 1f;
    float cooldowntimer = 1f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        cooldowntimer += Time.deltaTime;

        if (cooldowntimer >= cooldown)
        {
            clone = (GameObject)Instantiate(Bullet, transform.position, Quaternion.identity);
            clone.GetComponent<Rigidbody>().transform.position = this.gameObject.transform.position + new Vector3(-1f,0,0);
            clone.GetComponent<Rigidbody>().velocity = new Vector3(-15, 0);

            clone2 = (GameObject)Instantiate(Bullet, transform.position, Quaternion.identity);
            clone2.GetComponent<Rigidbody>().transform.position = this.gameObject.transform.position + new Vector3(1f, 0, 0);
            clone2.GetComponent<Rigidbody>().velocity = new Vector3(15, 0);

            clone3 = (GameObject)Instantiate(Bullet, transform.position, Quaternion.identity);
            clone3.GetComponent<Rigidbody>().transform.position = this.gameObject.transform.position + new Vector3(0, -1f, 0);
            clone3.GetComponent<Rigidbody>().velocity = new Vector3(0, -15);

            clone4 = (GameObject)Instantiate(Bullet, transform.position, Quaternion.identity);
            clone4.GetComponent<Rigidbody>().transform.position = this.gameObject.transform.position + new Vector3(0, 1f, 0);
            clone4.GetComponent<Rigidbody>().velocity = new Vector3(0, 15);
            cooldowntimer = 0;
        }
    }
}
