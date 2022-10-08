using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trigerr : MonoBehaviour
{
    // Start is called before the first frame update
    int deaths;
    public Text textbox;
    public Transform player;
    //public DeathShower other;
    public Transform respawnPoint;
    private void OnTriggerEnter(Collider other) // On touch of the wall
    {
        /*
       
        Debug.Log(other.name);
        */
        /* void OnTriggerEnter(Collider other)
        {
            if (other.name == "Player")
            {
                other.GetComponent<Player>().KillMe();
            }
        }*/
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
