using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameControl : MonoBehaviour
{
    [SerializeField]
    private Transform[] puzzle;
    


    [SerializeField]
    private GameObject winText;
    public static bool youwin;


    void Start()
    {
        winText.SetActive(false);
        youwin = false;
    }

     void Update()
    {
        if (puzzle[0].rotation.z == 0 &&
            puzzle[1].rotation.z==0 &&
            puzzle[2].rotation.z==0 &&
            puzzle[3].rotation.z==0 &&
            puzzle[4].rotation.z==0 &&
            puzzle[5].rotation.z==0 &&
            puzzle[6].rotation.z==0 &&
            puzzle[7].rotation.z==0 &&
            puzzle[8].rotation.z == 0)
        {
            youwin = true;
            winText.SetActive(true);
            SceneManager.LoadScene("puzzlegamebydanial");

        }
    }
}
