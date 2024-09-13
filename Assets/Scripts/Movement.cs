using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float mainThrust = 450;
    [SerializeField] float rotationThrust = 10;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        ProccessThrust();
        ProccessRotation();
         
    }
    void ProccessThrust()
    {
        if (Input.GetKey(KeyCode.Space))
        {          
            rb.AddRelativeForce(Vector3.up * mainThrust * Time.deltaTime);
        }
    }
    void ProccessRotation()
    {
        if (Input.GetKey(KeyCode.D))
        {
            ApplyRotation(rotationThrust);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            ApplyRotation(-rotationThrust);
        }
    }

    private void ApplyRotation(float rotationThisFrame)
    {
        rb.freezeRotation =true;
        transform.Rotate(Vector3.back * rotationThisFrame * Time.deltaTime);
        rb.freezeRotation = false;
    }
}
