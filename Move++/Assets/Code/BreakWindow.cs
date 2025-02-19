using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakWindow : MonoBehaviour
{
    
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "thrownRock(Clone)")
        {
            Destroy(this.transform.gameObject);
            Debug.Log("*CRASH*");
        }
    }
}
