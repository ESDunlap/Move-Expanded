using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUp : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            Destroy(this.transform.parent.gameObject);
            Debug.Log("Grants speed up to both you and enemies when they touch it.");
        }
    }
}
