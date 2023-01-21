using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float speed = 5f;
    private float rotationSpeed = 100f;

    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    

    private void FixedUpdate()
    {
        float vertAxis = Input.GetAxis("Vertical");
        float horAxis = Input.GetAxis("Horizontal");
        rb.velocity = (transform.forward * vertAxis) * speed * Time.deltaTime;
        transform.Rotate((transform.up * horAxis) * rotationSpeed * Time.deltaTime);
    }
}
