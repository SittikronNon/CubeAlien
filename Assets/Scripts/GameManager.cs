using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject enemy;
    public GameObject spawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(enemy, spawnPoint.transform.position, spawnPoint.transform.rotation);
        Debug.Log("TEST");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
