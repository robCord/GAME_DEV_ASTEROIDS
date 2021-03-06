﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Transform tf;
    public float RotationSpeed = 1.0f;
    public float MovementSpeed = 1.0f;

    public GameObject bulletPrefab;

    public Transform firePoint;
    // Start is called before the first frame update
    void Start()
    {
        tf = gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            tf.position += tf.right * MovementSpeed * Time.deltaTime;
            // tf.position += Vector3.up;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            tf.Rotate(0, 0, RotationSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            tf.Rotate(0, 0, -RotationSpeed * Time.deltaTime);
        }
        //input for shoot
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }
    //firing function
    public void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }

    void OnCollisionEnter2D(Collision2D otherObject)
    {
        Debug.Log("[Collision Entered] The GameObject of the other object is named: " + otherObject.gameObject.name);
    }

    void OnCollisionExit2D(Collision2D otherObject)
    {
        Debug.Log("[Collision Exited] The GameObject of the other object is named: " + otherObject.gameObject.name);
    }

    void OnDestroy()
    {
        // If the player dies, they lose a life.
        GameManager.instance.lives -= 1;
        if (GameManager.instance.lives > 0)
        {
            GameManager.instance.Respawn();
        }
        else
        {
            Debug.Log("Game Over");
        }
    }


}