using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] 
    public float speed = 5f;
    private float rotationSpeed = 150f;

    public Slider slider;
    public float startingHealth = 100f;
    private float health;

    
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        health = startingHealth;
    }

    public void SetHealth()
    {
        slider.value = health;
    }
    

    private void FixedUpdate()
    {
        float vertAxis = Input.GetAxis("Vertical");
        float horAxis = Input.GetAxis("Horizontal");
        rb.velocity = (transform.forward * vertAxis) * speed * Time.deltaTime;
        transform.Rotate((transform.up * horAxis) * rotationSpeed * Time.deltaTime);
    }

   
}
