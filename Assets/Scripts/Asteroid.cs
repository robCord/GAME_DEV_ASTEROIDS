﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameManager.instance.enemiesList.Add(this.gameObject);
        //aim at the player at the start
    }

    // Update is called once per frame
    void Update()
    {
        //always move forward
    }

    void OnDestroy()
    {
        GameManager.instance.enemiesList.Remove(this.gameObject);
    }

    void OnCollision2D(Collision2D otherObject)
    {
        Debug.Log("Detected");
        if (otherObject.gameObject == GameManager.instance.player)
        {
            Destroy(otherObject.gameObject);
            Destroy(this.gameObject);
        }
        
    }
}
