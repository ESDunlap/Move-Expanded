using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EMP_Collectable : MonoBehaviour
{
    public GameBehavior gameManager;
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameBehavior>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Destroy(this.transform.parent.gameObject);
            Debug.Log("Bring to a power tower to destroy it");
            gameManager.EMPs += 1;

        }
    }
}




