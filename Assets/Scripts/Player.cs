using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Transform tf;
    public float RotationSpeed = 1.0f;
    public float MovementSpeed = 1.0f;
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
        throw new NotImplementedException();
    }

    void OnCollisionEnter2D(Collision2D otherObject)
    {
        Debug.Log("detected" + otherObject.gameObject.name);
    }

}