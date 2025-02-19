using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Rock : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Destroy(this.gameObject);
            Debug.Log("Break a Window");
            PlayerBehavior Player = collision.gameObject.GetComponent<PlayerBehavior>();
            Player.hasRock= true;
        }
    }
}
