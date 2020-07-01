using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class red_key : MonoBehaviour
{
    public GameObject key;
    public GameObject player;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == ("Player")) 
        { 
        key.transform.parent = player.transform;
        
        }
    }
}
