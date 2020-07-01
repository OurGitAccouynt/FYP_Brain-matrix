using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class game_management : MonoBehaviour
{
    public GameObject[] Conditions;
    public static int identifier_panel;
    bool go;

    public static int stats_Time;
    public static bool tool1;//axe
    public static bool tool2;//chainsaw
    public static bool tool3;//match stick
    public static bool tool4;//flash_light
    public static bool tool5;//best_climb_kit
    public static bool tool6;//standard_climb_kit
    public static bool tool7;//hydroplain
    public static bool tool8;//express crusier
    public static bool tool9;
    public static bool tool10;



    void Start()
    {
        go = true;
        identifier_panel = 0;
        stats_Time = 0;
        tool1 = false;
        tool10 = false;
        tool3 = false;
        tool4 = false;
        tool5 = false;
        tool6 = false;
        tool7 = false;
        tool8 = false;
        tool9 = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (identifier_panel == 0 && go)
        {
            disableAll();
            Conditions[identifier_panel].SetActive(true);
        }
        if (identifier_panel == 1 && go)
        {
            disableAll();
            Conditions[identifier_panel].SetActive(true);
        }
        if (identifier_panel == 2 && go)
        {
            disableAll();
            Conditions[identifier_panel].SetActive(true);
        }
        if (identifier_panel == 3 && go)
        {
            disableAll();
            Conditions[identifier_panel].SetActive(true);
        }
        if (identifier_panel == 4 && go)
        {
            disableAll();
            Conditions[identifier_panel].SetActive(true);
        }
        if (identifier_panel == 5 && go)
        {
            disableAll();
            Conditions[identifier_panel].SetActive(true);
        }
        if (identifier_panel == 6 && go)
        {
            disableAll();
            Conditions[identifier_panel].SetActive(true);
        }
        if (identifier_panel == 7 && go)
        {
            disableAll();
            Conditions[identifier_panel].SetActive(true);
        }
        if (identifier_panel == 8 && go)
        {
            disableAll();
            Conditions[identifier_panel].SetActive(true);
        }
        if (identifier_panel == 9 && go)
        {
            disableAll();
            Conditions[identifier_panel].SetActive(true);
        }
        if (identifier_panel == 10 && go)
        {
            disableAll();
            Conditions[identifier_panel].SetActive(true);
        }
        if (identifier_panel == 11 && go)
        {
            disableAll();
            Conditions[identifier_panel].SetActive(true);
        }
        if (identifier_panel == 12 && go)
        {
            disableAll();
            Conditions[identifier_panel].SetActive(true);
        }
       
    }
    public void left()
    {
        go = true;
        if (identifier_panel != 0)
        {
            identifier_panel--;
        }
       /* else
        {
            identifier_panel = Conditions.Length - 1;
        }*/

    }
    public void right()
    {
        go = true;
        if (identifier_panel != Conditions.Length - 1)
        {
            identifier_panel++;
        }
        /*    else
        {
            identifier_panel = 0;
        }*/
    }
    public void disableAll()
    {
        go = false;
        for (int i = 0; i < Conditions.Length; i++)
        {
            Conditions[i].SetActive(false);
        }
    }

   public void accept() 
    {
        disableAll();
        if (identifier_panel == 0 )
        {
            stats_Time = 750000;
            tool7 = true;
            tool2 = true;
            tool5 = true;

        }
        if (identifier_panel == 1 )
        {
            stats_Time = 2000000;
            tool8 = true;
            tool1 = true;
            tool6 = true;


        }
        if (identifier_panel == 2)
        {

            stats_Time = 750000;
            tool7 = true;
            tool2 = true;
            tool5 = true;
        }
        if (identifier_panel == 3 )
        {
            stats_Time = 750000;
            tool7 = true;
            tool2 = true;
            tool5 = true;

        }
        if (identifier_panel == 4 )
        {
            stats_Time = 1000000;
            tool7 = true;
            tool2 = true;
            tool5 = true;

        }
        if (identifier_panel == 5 )
        {
            stats_Time = 2000000;
            tool8 = true;
            tool1 = true;
            tool6 = true;

        }
        if (identifier_panel == 6 )
        {
            stats_Time = 2000000;
            tool8 = true;
            tool1 = true;
            tool6 = true;
        }
        if (identifier_panel == 7 )
        {
            stats_Time = 750000;
            tool7 = true;
            tool2 = true;
            tool5 = true;
        }
        if (identifier_panel == 8 )
        {
            stats_Time = 750000;
            tool7 = true;
            tool2 = true;
            tool5 = true;
        }
        if (identifier_panel == 9 )
        {
           
        }
        if (identifier_panel == 10 )
        {
            
        }
        if (identifier_panel == 11 )
        {
            
        }
        if (identifier_panel == 12 )
        {
            
        }



    }
    public void accept2() 
    {
        disableAll();
        if (identifier_panel == 0 )
        {
            stats_Time += 1000000;
            tool4 = true;
        }
        if (identifier_panel == 1 )
        {
            stats_Time += 500000;
            tool3 = true;
        }
        if (identifier_panel == 2 )
        {
            stats_Time += 300000;
            tool3 = true;
        }
        if (identifier_panel == 3 )
        {
            stats_Time += 800000;
            tool4 = true;
        }
    }
}
