using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerStats : MonoBehaviour
{
    [SerializeField] 
    public float speed = 5f;
    private float rotationSpeed = 150f;

    public int maxHealth = 100;
    public int currentHealth;
    public HealthBar healthBar;


    
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        rb = GetComponent<Rigidbody>();

    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            TakeDamage(20);
        }
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }

    private void FixedUpdate()
    {
        float vertAxis = Input.GetAxis("Vertical");
        float horAxis = Input.GetAxis("Horizontal");
        rb.velocity = (transform.forward * vertAxis) * speed * Time.deltaTime;
        transform.Rotate((transform.up * horAxis) * rotationSpeed * Time.deltaTime);
    }

   
}
