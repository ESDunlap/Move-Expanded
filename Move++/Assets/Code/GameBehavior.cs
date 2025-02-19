using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameBehavior : MonoBehaviour
{
    public bool showWinScreen = false;
    public bool showLossScreen = false;
    public string labelText = "Destroy all 4 towers and free nature!";
    public int maxTowers = 4;
    private int _towersDestroyed = 0;
    private int currentEMPs = 0;
    public int Towers
    {
        get { return _towersDestroyed;}
        set
        {
            _towersDestroyed = value;
            Debug.LogFormat("Destroyed Towers: {0}", _towersDestroyed);
        }
    }
    public int EMPs
    {
        get { return currentEMPs; }
        set
        {
            currentEMPs = value;
            Debug.LogFormat("Current EMPs {0}", currentEMPs);
        }
    }
    private int _playerHP = 3;
    public int HP
    {
        get { return _playerHP; }
        set
        {
            _playerHP = value;
            Debug.LogFormat("Lives: {0}", _playerHP);
            if (_playerHP <= 0)
            {
                labelText = "You want another life with that?";
                showLossScreen = true;
                Time.timeScale = 0;
            }
            else
            {
                labelText = "Ouch... that's got hurt.";
            }
        }
    }
    void Start()
    {
        Time.timeScale = 1.0f;
    }
    void Update()
    {
        if (_towersDestroyed >= maxTowers)
        {
            labelText = "You've found all the items!";
            showWinScreen = true;
            Time.timeScale = 0f;
        }
        else if (_towersDestroyed > 0)
        {
            labelText = "Tower destroyed! only " + (maxTowers - _towersDestroyed) + " towers left!";
        }
        else
        {
            labelText = "Destroy all 4 towers and free nature!";
        }
    }

    void OnGUI()
    {
        GUI.Box(new Rect(20, 20, 150, 25), "Player Health:" +
            _playerHP);
        GUI.Box(new Rect(20, 50, 150, 25), "EMPs Collected: " +
           currentEMPs);
        GUI.Box(new Rect(20, 80, 150, 25), "Towers Destroyed: " +
           _towersDestroyed);
        GUI.Label(new Rect(Screen.width / 2 - 100, Screen.height -
           50, 300, 50), labelText);
        if (showWinScreen)
        {
            Time.timeScale = 0.0f;
            if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 50, 200, 100), "YOU WON!"))
            {
                SceneManager.LoadScene(0);
            }
        }
        if (showLossScreen)
        {
            if (GUI.Button(new Rect(Screen.width / 2 - 100,
              Screen.height / 2 - 50, 200, 100), "You lose..."))
            {
                SceneManager.LoadScene(0);
            }
        }
    }
}
