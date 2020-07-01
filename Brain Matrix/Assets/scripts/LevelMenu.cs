﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

using UnityEngine.UI;
////using DG.Tweening;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

using DG.Tweening;
public class LevelMenu : MonoBehaviour
{

    // Use this for initialization

    GameObject listItemg;
    GameObject mainContainer;
    List<GameObject> groups;


    void Start()
    {

        GameManager.getInstance().init();
        GameData.getInstance().resetData();
        Localization.Instance.SetLanguage(GameData.getInstance().GetSystemLaguage());


        if (all_game != null) return;
        SceneManager.LoadScene("Game", LoadSceneMode.Additive);


        GameData.getInstance().currentScene = 1;

        GameObject.Find("btneasy").GetComponentInChildren<Text>().text = Localization.Instance.GetString("btneasy");
        GameObject.Find("btnmedium").GetComponentInChildren<Text>().text = Localization.Instance.GetString("btnmedium");
        GameObject.Find("btnadvanced").GetComponentInChildren<Text>().text = Localization.Instance.GetString("btnadvanced");
        GameObject.Find("btnhard").GetComponentInChildren<Text>().text = Localization.Instance.GetString("btnhard");
        GameObject.Find("btnexpert").GetComponentInChildren<Text>().text = Localization.Instance.GetString("btnexpert");

        GameObject.Find("txttitle").GetComponent<Text>().text = Localization.Instance.GetString("levelTitle");

        initLevels();
    }

    GameObject all_mainMenu;//main menu ui container
    GameObject all_level;//levelmenu container
    GameObject all_game;

    GameObject difficultPanel;
    GameObject controlbar;
    GameObject btnDiff;

    Vector3 middlestart;
    private void OnEnable()
    {

        difficultPanel = GameObject.Find("middle");
        middlestart = difficultPanel.transform.position;
        //difficultPanel.SetActive(false);
        controlbar = GameObject.Find("controlbar");
        //controlbar.SetActive(false);
        mainContainer = GameObject.Find("mainContainer");
        //mainContainer.SetActive(false);
        btnDiff = GameObject.Find("btnDiff");


        all_mainMenu = GameObject.Find("all_mainMenu");
        all_level = GameObject.Find("all_level");
        all_game = GameObject.Find("all_game");

        

        if (all_mainMenu != null)//only when start menu loaed
        {
            all_level.transform.Translate(Screen.width, 0, 0);
        }
        

    }

    void initLevels()
    {
        initView();
        GameData.getInstance().currentScene = 1;//1 is levelmenu
        groups = new List<GameObject>();
        mainContainer.SetActive(true);
        //foreach (Transform group_ in mainContainer.transform)
        //{
        //    groups.Add(group_.gameObject);
        //}


    }

    public void refreshLevel()
    {
        GameData.instance.currentScene = 1;
        difficultPanel.transform.position = new Vector2(difficultPanel.transform.position.x, middlestart.y);
        GameData.instance.isLock = false;

    }


    // Update is called once per frame
    void Update()
    {


    }

    bool isMoving = false;
    public void move(float dis)
    {
        if (canmove)
        {
            foreach (Transform m in mainContainer.transform)
            {
                m.transform.Translate(dis, 0, 0);
            }
            isMoving = true;
        }
    }

    /// <summary>
    /// simulate Swipes the page to is right position
    /// </summary>
    /// <param name="force">Force.</param>
    public void swipePage(float force)
    {


        if (Mathf.Abs(force) < 1f)
        {//user not do a quick swipe
            if (groups[page].transform.position.x < Screen.width / 4)
            {
                if (page >= 0 && page < pages)
                {
                    GoRight();
                }
                else
                {
                    returnPage();
                }

            }
            else if (groups[page].transform.position.x > Screen.width)
            {
                if (page <= pages && page > 0)
                {
                    GoLeft();
                }
                else
                {
                    returnPage();

                }
            }
            else
            {
                returnPage();
            }

        }
        else
        {
            if (groups[page].transform.position.x < Screen.width / 2)
            {
                if (page >= 0 && page < pages)
                {
                    GoRight();
                }
                else
                {
                    returnPage();
                }

            }
            else if (groups[page].transform.position.x > Screen.width / 2)
            {
                if (page <= pages && page > 0)
                {
                    GoLeft();
                }
                else
                {
                    returnPage();

                }
            }
            else
            {
                returnPage();
            }
        }

        //not allow level buttons active while moving the menu
        StopCoroutine("swiped");
        StartCoroutine("swiped");

    }

    //lock the game while page is auto moving.Unlock when finished
    IEnumerator swiped()
    {
        yield return new WaitForEndOfFrame();
        isMoving = false;
    }

    public GameObject levelButton;//the level button template instance
    public GameObject dot;//the page dot for turn page

    int page = 0;//current page
    int pages = 1;//how many page
    public int perpage = 8;//icons per page
    List<GameObject> gContainer;//each icon group for per page
    List<GameObject> pageDots;//all page dots
    float gap = Screen.width / 8.5f;//the gap for each page
    public Image mask;//the fade in/out mask
    void initView()
    {



        //pageDots = new List<GameObject>();


        //pages = Mathf.FloorToInt((GameData.totalLevel[GameData.difficulty] - 1) / perpage);
        //for (int i = 0; i <= pages; i++)
        //{
        //    GameObject tdot = Instantiate(dot, dot.transform.parent) as GameObject;
        //    tdot.SetActive(true);
        //    pageDots.Add(tdot);
        //    tdot.name = "dot_" + i;

        //}

        //setpageDot();
        //fadeOut ();

        //gContainer = new List<GameObject>();
        //gContainer.Add(levelButton.transform.parent.gameObject);

        Transform container = levelButton.transform.parent;
        container.transform.localScale = Vector3.one;

        //for (int i = perpage; i < GameData.totalLevel[GameData.difficulty]; i += perpage)
        //{
        //    GameObject tgroup = Instantiate(levelButton.transform.parent.gameObject, levelButton.transform.parent.position, Quaternion.identity) as GameObject;
        //    tgroup.transform.Translate(gap * (i + 1), 0, 0);
        //    gContainer.Add(tgroup);

        //    tgroup.transform.parent = levelButton.transform.parent.gameObject.transform.parent;
        //}


        for (int i = 0; i < GameData.totalLevel[GameData.difficulty]; i++)
        {
            GameObject tbtn = Instantiate(levelButton,container.transform) as GameObject;

            //int tContainerNo = Mathf.FloorToInt(i / perpage);
            //tbtn.transform.parent = gContainer[tContainerNo].transform;

            tbtn.SetActive(true);


            tbtn.GetComponentInChildren<Text>().text = (i + 1).ToString();





            Text ttext = tbtn.GetComponentInChildren<Text>();


          


            //star not used for this game
            //if (GameData.getInstance().lvStar.Count > i)
            //{

            //    int starCount = GameData.getInstance().lvStar[i];


            //    if (GameData.getInstance().lvStar.Count > i + 1)
            //    {
            //        for (int j = 1; j <= starCount; j++)
            //        {
            //            ttext.transform.parent.Find("star" + j).GetComponent<Image>().enabled = true;
            //        }
            //    }
            //}


            //if (i > GameData.getInstance().levelPassed && i > 0)
            //{

            //    ttext.enabled = false;




            //}
            //else
            //{


            tbtn.name = "level" + (i + 1);
            tbtn.GetComponent<UnityEngine.UI.Button>().onClick.AddListener(() => clickLevel(tbtn));
            ttext.gameObject.transform.parent.Find("lock").GetComponent<Image>().enabled = false;

            //}

        }


        //GameObject.Find("txtScore").GetComponent<Text>().text = Localization.Instance.GetString("totalScore") + GameData.getInstance().bestScore;
        GameObject btnConfirm = GameObject.Find("confirm");//
        if (btnConfirm != null) btnConfirm.GetComponentInChildren<Text>().text = Localization.Instance.GetString("continue");


    }

    //refresh button states
    public void refreshView()
    {
        //print(GameData.difficulty);
        for (int i = 0; i < GameData.totalLevel[GameData.difficulty]; i++)
        {
            GameObject tbtn = GameObject.Find("level" + (i+1));
            if (tbtn != null)
            {
                int tlevelButtonState = GameData.instance.levelStates[GameData.difficulty][i];
                if (tlevelButtonState == 1)
                {
                    tbtn.GetComponent<Image>().color = new Color32(176, 62, 86, 255);
                }
                else {
                    tbtn.GetComponent<Image>().color = new Color32(40, 75, 130, 255); 
                }
            }
        }

       

    }


    /// <summary>
    /// Clicks the dot. For turn page,not used
    /// </summary>
    /// <param name="tdot">Tdot.</param>
    public void clickDot(GameObject tdot)
    {
        int tdotIndex = int.Parse(tdot.transform.parent.name.Substring(4, tdot.transform.parent.name.Length - 4));
        page = tdotIndex;
        canmove = false;


        ATween.MoveTo(gContainer[0].transform.parent.gameObject, ATween.Hash("ignoretimescale", true, "islocal", true, "x", -gContainer[page].transform.localPosition.x, "time", .3f, "easeType", "easeOutExpo", "oncomplete", "dotclicked", "oncompletetarget", this.gameObject));


    }

    /// <summary>
    /// page turned,not used
    /// </summary>
    void dotclicked()
    {
        canmove = true;
        setpageDot();

    }


    public static bool islock = false;
    /// <summary>
    /// Clicks the level button.
    /// </summary>
    /// <param name="tbtn">Tbtn.</param>
    void clickLevel(GameObject tbtn)
    {
        if (GameData.instance.isLock) return;
        GameManager.getInstance().playSfx("click");
        GameData.getInstance().cLevel = int.Parse(tbtn.GetComponentInChildren<Text>().text) - 1;
        if (GameData.instance.mode == 1)//the fade transition for test only
        {
            if (!isMoving)
            {
               
                fadeIn("game");
            }
        }
        else//load level
        {
            all_game = GameObject.Find("all_game");

            all_game.transform.parent.GetComponent<MainScript>().refreshView();//some ui must active before anim finishes;
            all_level.transform.DOMoveX(all_level.transform.position.x - Screen.width, 1f).SetEase(Ease.OutBounce).OnComplete(() => {
                all_game.transform.parent.GetComponent<MainScript>().init();
            });
           
            if (all_game != null)
            {
                all_game.transform.DOMoveX(0, 1f).SetEase(Ease.OutBounce);
            }
        }


    }
    /// <summary>
    /// set to choose difficulty page
    /// </summary>
    public void chooseDiff() {
        if (GameData.instance.isLock) return;
        GameData.instance.isLock = true;
        difficultPanel.transform.DOMoveY(middlestart.y, .4f).OnComplete(() => {
            GameData.instance.isLock = false;
  
        });
    }

    /// <summary>
    /// Set dots for pages.not used
    /// </summary>
    void setpageDot()
    {
        for (int i = 0; i < pageDots.Count; i++)
        {
            pageDots[i].GetComponent<Image>().color = new Color(1, 1, 1, .5f);
        }
        pageDots[page].GetComponent<Image>().color = new Color(1, 1, 1, 1);
    }


    /// <summary>
    /// touch the continue to Continues your last level.not used
    /// </summary>
    public void continueLevel()
    {

        int tLastLevel = GameData.getInstance().levelPassed;

        if (tLastLevel < GameData.totalLevel[GameData.difficulty])
        {
            GameData.getInstance().cLevel = tLastLevel;
        }
        else
        {
            GameData.getInstance().cLevel = GameData.totalLevel[GameData.difficulty];
        }

        string tstr = "game";// + GameData.getInstance ().cLevel;


        if (GameData.instance.mode == 1)//this is always for test because you may not start from the initiate window.
        {
            fadeIn(tstr);

        }
        else
        {

            all_level.transform.DOMoveX(all_level.transform.position.x - Screen.width, 1f).SetEase(Ease.OutBounce).OnComplete(() => { all_game.transform.parent.GetComponent<MainScript>().init(); });
            all_game = GameObject.Find("all_game");
            if (all_game != null)
            {
                all_game.transform.DOMoveX(0, 1f).SetEase(Ease.OutBounce);
            }
        }





    }

    /// <summary>
    /// Backs the main scene.
    /// </summary>
    public void backMain()
    {
        if (islock) return;
        GameManager.getInstance().playSfx("click");
        if (all_mainMenu == null || GameData.instance.mode == 1)//this is always for test because you may not start from the initiate window.
        {
            fadeIn("MainMenu");
        }
        else
        {
            GameData.instance.isLock = true;
            all_mainMenu.transform.DOMoveX(all_mainMenu.transform.position.x + Screen.width, 1f).SetEase(Ease.OutBounce).OnComplete(() => { GameData.instance.currentScene = 0; GameData.instance.isLock = false; });
            all_level.transform.DOMoveX(all_level.transform.position.x + Screen.width, 1f).SetEase(Ease.OutBounce);
        }



    }

    /// <summary>
    /// Loads the game scene.
    /// </summary>
    public void loadGameScene()
    {

        SceneManager.LoadScene("Game");
    }
    /// <summary>
    /// Loads the main scene.
    /// </summary>
    public void loadMainScene()
    {

        SceneManager.LoadScene("MainMenu");
    }


    bool canmove = true;//can not enter a level and can not move when moving
                        /// <summary>
                        /// page Goes right.not used
                        /// </summary>
    public void GoRight()
    {
        if (!canmove)
            return;
        if (page < pages)
        {

            page++;
            canmove = false;


            ATween.MoveTo(gContainer[0].transform.parent.gameObject, ATween.Hash("ignoretimescale", true, "islocal", true, "x", -gContainer[page].transform.localPosition.x, "time", .3f, "easeType", "easeOutExpo", "oncomplete", "dotclicked", "oncompletetarget", this.gameObject));


        }
    }
    /// <summary>
    /// page goes left.
    /// </summary>
    public void GoLeft()
    {
        if (!canmove)
            return;
        if (page > 0)
        {

            page--;
            canmove = false;


            ATween.MoveTo(gContainer[0].transform.parent.gameObject, ATween.Hash("ignoretimescale", true, "islocal", true, "x", -gContainer[page].transform.localPosition.x, "time", .3f, "easeType", "easeOutExpo", "oncomplete", "dotclicked", "oncompletetarget", this.gameObject));


        }
    }


    void fadeOut()
    {
        mask.gameObject.SetActive(true);
        mask.color = Color.black;

        ATween.ValueTo(mask.gameObject, ATween.Hash("ignoretimescale", true, "from", 1, "to", 0, "time", 1, "onupdate", "OnUpdateTween", "onupdatetarget", this.gameObject, "oncomplete", "fadeOutOver", "oncompletetarget", this.gameObject));

    }

    void fadeIn(string sceneName)
    {
        if (mask.IsActive())
            return;
        mask.gameObject.SetActive(true);
        mask.color = new Color(0, 0, 0, 0);

        ATween.ValueTo(mask.gameObject, ATween.Hash("ignoretimescale", true, "from", 0, "to", 1, "time", 1, "onupdate", "OnUpdateTween", "onupdatetarget", this.gameObject, "oncomplete", "fadeInOver", "oncompleteparams", sceneName, "oncompletetarget", this.gameObject));

    }


    /// <summary>
    /// when Fadein over.
    /// </summary>
    /// <param name="sceneName">Scene name.</param>
    void fadeInOver(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    /// <summary>
    /// when fade out over
    /// </summary>
    void fadeOutOver()
    {
        mask.gameObject.SetActive(false);
    }

    /// <summary>
    /// tween update event
    /// </summary>
    /// <param name="value">Value.</param>
    void OnUpdateTween(float value)

    {

        mask.color = new Color(0, 0, 0, value);
    }




    /// <summary>
    /// Returns the page to its origin place.
    /// </summary>
    void returnPage()
    {
        canmove = false;
        ATween.MoveTo(gContainer[page].transform.parent.gameObject, ATween.Hash("ignoretimescale", true, "islocal", true, "x", -gContainer[page].transform.localPosition.x, "time", .3f, "easeType", "easeOutExpo", "oncomplete", "dotclicked", "oncompletetarget", this.gameObject));

    }

    /// <summary>
    /// cliked and choosed a difficulty on difficulty choose ui
    /// </summary>
    /// <param name="g"></param>
    public void selectDifficulty(GameObject g)
    {
        if (GameData.instance.isLock) return;
        GameManager.getInstance().playSfx("click");
        switch (g.name)
        {
            case "btneasy":
                GameData.difficulty = 0;
                break;
            case "btnmedium":
                GameData.difficulty = 1;
                break;
            case "btnadvanced":
                GameData.difficulty = 2;
                break;
            case "btnhard":
                GameData.difficulty = 3;
                break;
            case "btnexpert":
                GameData.difficulty = 4;
                break;
        }

        GameData.instance.isLock = true;
        difficultPanel.transform.DOMoveY(-Screen.height, .4f).OnComplete(()=> {
            GameData.instance.isLock = false;

        });
        refreshView();


    }


    //debug use
    public void debugtext(string str)
    {
        //GameObject.Find ("txtScores").GetComponent<Text> ().text = str;
    }



}
