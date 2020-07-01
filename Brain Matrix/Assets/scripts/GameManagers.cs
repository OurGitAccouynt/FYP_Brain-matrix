using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagers : MonoBehaviour
{
    public static string mlevel;
    public static string plevel;
    public string level1;
    public string level2;
    public string level3;

    public string level11;
    public string level22;

    void Start()
    {
        
    }
  
    void Update()
    {
        
    }

    public void measy()
    {
        mlevel = "a";

    }
    public void mmedium()
    {
        mlevel = "b";

    }
    public void mhard()
    {

        mlevel = "c";
    }

    public void peasy()
    {

        mlevel = "aa";
    }

    public void pmedium()
    {
        mlevel = "bb";

    }

    public void start()
    {
        if (mlevel == ("a"))
        {
            Application.LoadLevel(level1);
            Debug.Log("Level1");
        }
        if (mlevel == ("b"))
        {
            Application.LoadLevel(level2);
            Debug.Log("Level2");
        }
        if (mlevel == ("c"))
        {
            Application.LoadLevel(level3);
            Debug.Log("Level3");
        }
        if (mlevel == ("aa"))
        {
            Application.LoadLevel(level11);
            Debug.Log("Level11");
        }
        if (mlevel == ("bb"))
        {
            Application.LoadLevel(level22);
            Debug.Log("Level22");
        }

    }

}
