using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Game_Menu : MonoBehaviour
{
    
    public void onclickMazeEasy()
    {
        SceneManager.LoadScene("easymaze");

    }
    public void onclickMazeMedium()
    {
        SceneManager.LoadScene("medmaze");
   
    }
    public void onclickMazeHard()
    {
        SceneManager.LoadScene("hardeasymaze");

    }
    public void onpuzzleeasy()
    {
        SceneManager.LoadScene("easypuzz");

    }
    public void onpuzzlemedium()
    {
        SceneManager.LoadScene("medpuzz");

    }
    public void onpuzzlhard()
    {
        SceneManager.LoadScene("hardpuzz");

    }
}
