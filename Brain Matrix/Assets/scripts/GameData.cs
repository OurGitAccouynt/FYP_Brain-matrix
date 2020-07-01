﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData : ScriptableObject
{// Singleton<GameData> {

    // Use this for initialization

    public int nLink = 0; //check in game.When nlink = 0.All the lines linked,so win.
    public int levelPassed = 0;//how much level you passed
    public int cLevel = 0;//currect level
    public int bestScore = 0;//bestscore for level
    public int isSoundOn = 0;//whether game music is on
    public int isSfxOn = 0;//whether the game sound effect is on
    public static bool isTrial;//not used
    public static string lastWindow = "";//not used

    public int currentScene = 0;

    public int tipRemain = 0;//how much tip you remain

    public MainScript main;//the mainscript instance of the game
    public static int[] totalLevel = {50,50,50,50,50};//total levels,currently,we make things easier,only use 50 levels the same for each difficulty
    public List<List<int>> levelStates;
    public static int difficulty = 0;//easy,
    public int mode = 0;




    public static GameData instance;
    public static GameData getInstance()
    {
        if (instance == null)
        {
            instance = ScriptableObject.CreateInstance<GameData>();
        }
        return instance;
    }

    public bool isWin = false;//check if win
    public bool isLock = false;//check if game ui can touch or lock and wait
    public string tickStartTime = "0";//game count down.
    public List<int> lvStar = new List<int>();//level stars you got for each level
    public bool isfail = false;//whether the game failed

    /// <summary>
    /// Always uses for initial or reset to start a new level.
    /// </summary>
    public void resetData()
    {
        isLock = false;
        isWin = false;
        isfail = false;
        //		levelPassed = PlayerPrefs.GetInt ("levelPass", 0);
        //		Debug.Log ("levelpassed=" + levelPassed);
        tipRemain = PlayerPrefs.GetInt("tipRemain", 3);
        tickStartTime = PlayerPrefs.GetString("tipStart", "0");


        //reset level pass states
        GameData.instance.levelStates = new List<List<int>>();
        //load levelState，check which level passed
        for (int i = 0; i < GameData.totalLevel.Length; i++)
        {
            List<int> tStates = new List<int>();
            for (int j = 0; j < GameData.totalLevel[GameData.difficulty]; j++)
            {
                int tState = PlayerPrefs.GetInt("linkdot_" + i + "_" + j);//gamename_difficulty_levelnum
                //if (j == 3 && i == 1) tState = 1;//test
                tStates.Add(tState);

            }
            GameData.instance.levelStates.Add(tStates);
        }
    }


    /// <summary>
    /// Gets the system laguage.
    /// </summary>
    /// <returns>The system laguage.</returns>
    public int GetSystemLaguage()
    {
        int returnValue = 0;
        switch (Application.systemLanguage)
        {
            case SystemLanguage.Chinese:
                returnValue = 1;
                break;
            case SystemLanguage.ChineseSimplified:
                returnValue = 1;
                break;
            case SystemLanguage.ChineseTraditional:
                returnValue = 1;
                break;
            default:
                returnValue = 0;
                break;

        }
        returnValue = 0;//test
        return returnValue;
    }















    SimpleJSON.JSONNode levelData;

    public void init()
    {

        string tData = Datas.CreateInstance<Datas>().getData("linkdots")[GameData.instance.cLevel];//level
        levelData = SimpleJSON.JSONArray.Parse(tData);



       
        //SimpleJSON.JSONNode levelSize = levelData[1]["levels"];//dot postion imformation(in pairs) //1 6x6 

        bsize = int.Parse(levelData["r"]);//int.Parse(levelData[1]["size"]);

        colors = new Color[] { Color.clear, new Color32(192, 57, 43, 255), new Color32(250, 219, 216, 255), new Color32(99, 57, 116, 255), new Color32(41, 128, 185, 255), new Color32(211, 232, 51, 255), new Color32(241, 196, 15,255), new Color32(211, 84, 0, 255), new Color32(236, 240, 241, 255), new Color32(170, 183, 184, 255), new Color32(86, 101, 115, 255), new Color32(246, 221, 204, 255), new Color32(162, 217, 206, 255) };
        ColorData = new int[bsize * bsize];
        DotColorData = new int[bsize * bsize];


        //string clevelStr = getLevel(0);
        ////print (clevelStr);
        //dotPoses = clevelStr.Split(";"[0]);

        dotPoses = levelData["l"];//this is actually is pathes between 2 dots


        GameData.instance.paths = new List<List<int>>();
        List<int> tpath0 = new List<int>();//the clear color path,not used;

        GameData.instance.paths.Add(tpath0);

        for (int i = 0; i < dotPoses.Count; i++)
        {
            List<int> tpath = new List<int>();
            GameData.instance.paths.Add(tpath);
        }
        winLinkCount = dotPoses.Count;
       

        linkedLines = new int[GameData.instance.paths.Count+1];

       
    }


    public string getLevel(int no)
    {

        return levelData[1]["levels"][no];
    }
    public bool isHolding = false;
    public int pickColor = -1;

    [HideInInspector]
    public SimpleJSON.JSONNode dotPoses;
    [HideInInspector]
    public int[] ColorData;
    [HideInInspector]
    public int[] DotColorData;
    [HideInInspector]
    public Color[] colors;
    [HideInInspector]
    public int startId = -1;
    [HideInInspector]
    public int lasttx = -1;
    [HideInInspector]
    public int lastty = -1;
    [HideInInspector]
    public List<List<int>> paths;
    [HideInInspector]
    public int[] linkedLines;//check all colors whehter links
    [HideInInspector]
    public static int bsize = 6;
    [HideInInspector]
    public int winLinkCount;//how many linkage requires to win(commonly its half of the number of dots)




    public void clearData()
    {
        Transform tcontainer = GameObject.Find("linkdot").transform.Find("container");
        foreach(Transform tobj in tcontainer)
        {
            Destroy(tobj.gameObject);
        }
      
    }
}





