using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameend : MonoBehaviour
{
    public GameObject levelcompletepanel;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            levelcompletepanel.SetActive(true);
        }
    }
}
