using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gunfire : MonoBehaviour
{
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            AudioSource gunsound = GetComponent< AudioSource > ();
            gunsound.Play();

        }
    }
}