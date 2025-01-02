using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public float jump;
    public Rigidbody2D rb2d;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            rb2d.velocity = Vector2.up * jump;
        }        
    }
}
