using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{

    public AudioSource coinsound;
    public int points= 0;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    void OnTriggerEnter(Collider other)
    {
        //other.GetComponent<PlayerScript>().points++;

        if (other.gameObject.name == "coin")
        {
            coinsound.Play();

            points += 1;

            Destroy(other.gameObject);



        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 100, 20), "Score : " + points);
    }
}
