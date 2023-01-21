using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectPuzzle : MonoBehaviour
{
    public GameObject door;
    public GameObject explosion;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            GameObject effectIns = (GameObject)Instantiate(explosion, door.transform.position, door.transform.rotation);
            Debug.Log("Door has been destroyed");
            Destroy(door);
            Destroy(effectIns, 2f);
        }
        else
            Debug.Log("You can't trigger this with other tag!!");

        Destroy(gameObject);
    }
}
