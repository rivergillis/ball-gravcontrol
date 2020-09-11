using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // This is how unity applies gravity
        rb.AddForce(GlobalState.gravity * Time.deltaTime, ForceMode.VelocityChange);
    }
}
