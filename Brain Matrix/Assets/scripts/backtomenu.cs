using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class backtomenu : MonoBehaviour
{

    public void menu() {
        StartCoroutine(ExampleCoroutine());
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator ExampleCoroutine()
    {

        yield return new WaitForSeconds(1.4f);
        SceneManager.LoadScene("menu");
    }
}
