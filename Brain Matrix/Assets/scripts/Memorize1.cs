using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Memorize1 : MonoBehaviour
{
    public GameObject OriginalTile1;
    public GameObject OriginalTile2;
    public GameObject OriginalTile3;
    public GameObject Hinttile1;
    public GameObject Hinttile2;
    public GameObject Hinttile3;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ActivateHintTiles());
        StartCoroutine(DiableHintTiles());
    }

    IEnumerator ActivateHintTiles()
    {
        WaitForSeconds waitForSeconds = new WaitForSeconds(1);
        yield return waitForSeconds;
        Hinttile1.SetActive(true);
        Hinttile2.SetActive(true);
        Hinttile3.SetActive(true);
        OriginalTile1.SetActive(false);
        OriginalTile2.SetActive(false);
        OriginalTile3.SetActive(false);

    }
    IEnumerator DiableHintTiles()
    {
        WaitForSeconds waitForSeconds = new WaitForSeconds(2);
        yield return waitForSeconds;
        OriginalTile1.SetActive(true);
        OriginalTile2.SetActive(true);
        OriginalTile3.SetActive(true);
        Hinttile1.SetActive(false);
        Hinttile2.SetActive(false);
        Hinttile3.SetActive(false);  
        
    }

    // Update is called once per frame
    void Update()
    {

    }


}
