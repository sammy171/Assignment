using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float movementSpeed = 0.0f;  //How fast we follow
    public Transform target;            //Object we want to follow

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // enemy locks-on with player
        transform.position = Vector3.MoveTowards(transform.position, target.position, movementSpeed);
    }
    void FixedUpdate()
    {
        Vector3 fwd = transform.TransformDirection(Vector3.right);
        Debug.DrawLine(transform.position, transform.position + fwd * 10f);
        if (Physics.Raycast(transform.position, fwd, 10))
            print("There is something in front of the object!");
    }
}
