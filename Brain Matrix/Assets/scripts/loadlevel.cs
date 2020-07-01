using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class loadlevels : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ExampleCoroutine());
    }

    // Update is called once per frame

    IEnumerator ExampleCoroutine()
    {

         yield return new WaitForSeconds(5);
        SceneManager.LoadScene("menu");
    }

    public void loadtest() {
    

    }
    void Update()
    {
        
    }
}
