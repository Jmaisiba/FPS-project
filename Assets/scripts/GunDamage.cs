using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunDamage : MonoBehaviour
{

    float bulletspeed = 1100;
    public GameObject bullet;
    public GameObject blood;

    // Start is called before the first frame update
    void Start()
    {

    }

    void fire()
    {

        Instantiate(blood, transform.position, Quaternion.identity);
        GameObject tempbullet = Instantiate(bullet, transform.position, transform.rotation) as GameObject;
        Rigidbody tempRigidBodyBullet = tempbullet.GetComponent<Rigidbody>();
        tempRigidBodyBullet.AddForce(tempRigidBodyBullet.transform.forward * bulletspeed);
        Destroy(tempbullet, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Fire1"))
        {
            fire();

        }
    }
}