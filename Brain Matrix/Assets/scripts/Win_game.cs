using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Win_game : MonoBehaviour
{
    public string levelname;
    public GameObject wingame;

    public void Update()
    {
      

    }
    private void OnTriggerEnter(Collider other)
    {
        //if (other.tag == "Player") 
        //{
        //    SceneManager.LoadScene(levelname);
        //    Debug.Log(levelname);
        //}
        wingame.SetActive(true);

    }
}
