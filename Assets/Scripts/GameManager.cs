using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{ 
    //public variables
    public GameObject playerPrefab;
    public GameObject player;
    public static GameManager Instance;
    public int Lives = 3;
    public int Score = 0;
    public bool IsPaused = false;

    public void Awake()
    { 
        if (Instance == null)
        {
            Instance = this; 
        }
        else
        {//prevents having two separate game managers 
            Destroy(this.gameObject);
            Debug.LogError("GameObject has been destroyed, tried to create a second game manager");
        }
    }
    
    private void Update()
    {
        //if player presses escape they will leave the game
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    public void Respawn()
    {
        Instantiate(playerPrefab);
    }

}
