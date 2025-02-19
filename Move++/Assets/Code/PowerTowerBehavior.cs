using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerTowerBehavior : MonoBehaviour
{
    public GameObject destruction;
    public GameBehavior gameManager;
    private void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameBehavior>();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player" && gameManager.EMPs > 0)
        {
            GameObject rubble = Instantiate(destruction, this.transform.position, this.transform.rotation) as GameObject;
            Rigidbody rubbleRB = rubble.GetComponent<Rigidbody>();
            Destroy(this.transform.parent.gameObject);
            Debug.Log("EMP set off!");
            gameManager.EMPs -= 1;
            gameManager.Towers += 1;
        }
    }
}
