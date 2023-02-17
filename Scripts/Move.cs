using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector3(rb.velocity.x, 3f, rb.velocity.z);
        }
        if (Input.GetButtonDown("w"))
        {
            rb.velocity = new Vector3(3f, 0, 0);
        }
        if (Input.GetKey("s"))
        {
            rb.velocity = new Vector3(-3f, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            rb.velocity = new Vector3(0, 0, 3f);
        }
        if (Input.GetKey("d"))
        {
            rb.velocity = new Vector3(0, 0, -3f);
        }
    }
}
