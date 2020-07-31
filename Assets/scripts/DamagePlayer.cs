using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePlayer : MonoBehaviour
{
    public int playerhealth=30;
    int damage=10;


    void Start()
    {
        print(playerhealth);

    }

    void OnCollisionEnter(Collision _collision)
    {

        if (_collision.gameObject.tag == "Enemy")
        {
            playerhealth -= damage;

            print("Health:" + playerhealth);
        }
        

        }
    }
