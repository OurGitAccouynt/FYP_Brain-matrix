using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Open : MonoBehaviour
{
    public GameObject key;
    public GameObject door;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "key") { 
        
            StartCoroutine(ExampleCoroutine());
        }
    }
    public void Start()
    {
        
      
    }
    IEnumerator ExampleCoroutine()
    {
        key.transform.parent = null;
        key.GetComponent<Animator>().enabled = true;
        yield return new WaitForSeconds(5);
        door.GetComponent<Animator>().enabled = true;

    }
}
