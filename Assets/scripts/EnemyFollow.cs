using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public float speed=8;
    public float dist;
    public float howclose=7;
    public Transform Player;


    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").transform;

    }

    // Update is called once per frame
    void Update()
    {

        dist = Vector3.Distance(Player.position, transform.position);

        if (dist<=howclose) {

            transform.LookAt(Player);
            GetComponent<Rigidbody>().AddForce(transform.forward * speed);

        }

        //melee attack
        if (dist <= 1.5)
        {

            //damage
        }

        }

        
        }
    
