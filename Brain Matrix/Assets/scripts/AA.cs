using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AA : MonoBehaviour
{
    public static char mcq;
    // Start is called before the first frame update
    void Start()
    {
        //  Text_change A1 = new Text_change();
        //Debug.Log("LOL"+Text_change.dataset[1]);
        //A1.Score_UIText.text = "afaffafafa";
        //A1.Score_A.text = "afaffafafa";
        //A1.Score_B.text = "afaffafafa";
        //A1.Score_C.text = "afaffafafa";
        //A1.Score_D.text = "afaffafafa";
        Button aa = gameObject.GetComponent<Button>();
        aa.onClick.AddListener(delegate () { ScoreA(); });
    }

    public void ScoreA()
    {
        mcq = 'A';
    }
}
