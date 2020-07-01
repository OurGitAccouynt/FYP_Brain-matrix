using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeDead : MonoBehaviour
{
    public float timer;
    public GameObject q1;
    public GameObject q2;
    public GameObject q3;
    public GameObject q4;
    public GameObject q5;
    public GameObject q6;
    public GameObject q7;
    public GameObject q8;
    public GameObject q9;
    public GameObject q10;
    public GameObject q11;
    public GameObject q12;

    public GameObject gameOverScreen;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(killLevel());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator killLevel()
    {
        WaitForSeconds waitForSeconds = new WaitForSeconds(timer);
        yield return waitForSeconds;
        q1.SetActive(false);
        q2.SetActive(false);
        q3.SetActive(false);
        q4.SetActive(false);
        q5.SetActive(false);
        q6.SetActive(false);
        q7.SetActive(false);
        q8.SetActive(false);
        q9.SetActive(false);
        q10.SetActive(false);
        q11.SetActive(false);
        q12.SetActive(false);

        gameOverScreen.SetActive(true);


    }
}
