using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InTimeWin : MonoBehaviour
{
    public float timer;
    public GameObject winPanel;
    public GameObject killTimer;
  

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(killTimeManager());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator killTimeManager()
    {
        WaitForSeconds waitForSeconds = new WaitForSeconds(timer);
        yield return waitForSeconds;
        killTimer.SetActive(false);
        winPanel.SetActive(true);


    }
}
