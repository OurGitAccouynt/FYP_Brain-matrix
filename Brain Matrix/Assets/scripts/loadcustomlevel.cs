using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class loadcustomlevel : MonoBehaviour
{

    public string level;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void loadnextlevel()
    {
        SceneManager.LoadScene(level);

    }
}
