using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DD : MonoBehaviour
{

    void Start()
    {
        Button dd = gameObject.GetComponent<Button>();
        dd.onClick.AddListener(delegate () { ScoreD(); });
    }

    public void ScoreD()
    {
        AA.mcq = 'D';
    }
}
