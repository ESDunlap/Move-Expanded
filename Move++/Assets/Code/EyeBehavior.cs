using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            Debug.Log("THE TOWER HAS DETECTED YOU ALL ENEMIES CONVERGE");
        }
    }

    // Update is called once per frame
    void OnTriggerExit(Collider other)
    {
        if (other.name == "Player")
        {
            Debug.Log("Player lost. Return to Regular patrol");
        }
    }
}
