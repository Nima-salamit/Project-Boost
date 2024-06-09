using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Movement : MonoBehaviour
{
    private Rigidbody rb;

    [SerializeField] float mainThrust = 100f;

    [SerializeField] float rotationThrust = 2f;
    // Start is called before the first frame update
    void Start()
    {
        // It is for physics
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        ProceesThrust();
        ProcessRotattion();
    }

    void ProceesThrust()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            // deltaTime is for frame rate independent
            rb.AddRelativeForce(Vector3.up * mainThrust * Time.deltaTime);
        }
    }

    void ProcessRotattion()
    {
        if (Input.GetKey(KeyCode.A))
        {
            ApplyRotation(rotationThrust);
        }
        
        else if (Input.GetKey(KeyCode.D))
        {
            ApplyRotation(-rotationThrust);
        }
    }

    private void ApplyRotation(float rotationThisFrame)
    {
        transform.Rotate(Vector3.forward * rotationThisFrame * Time.deltaTime);
    }
}