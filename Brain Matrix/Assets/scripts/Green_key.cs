using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Green_key : MonoBehaviour
{
    public GameObject text;
    private void OnTriggerEnter(Collider other)
    {
        text.SetActive(true);
    }
    private void OnTriggerExit(Collider other)
    {
        text.SetActive(false);
    }
}
