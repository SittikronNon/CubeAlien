using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public float startHealth = 100f;
    private float health;

    //private bool isDead = false;

    public Image healthBar;
    // Start is called before the first frame update
    void Start()
    {
        health = startHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(float damage)
    {
        Debug.Log("Hit");
        health -= damage;
        if(health <= 0)
        {
            
            Debug.Log("He is dead");
            Dead();
        }
    }

    public void Dead()
    {
        Destroy(gameObject);
    }
}
