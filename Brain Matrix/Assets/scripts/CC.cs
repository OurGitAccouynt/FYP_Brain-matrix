using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CC : MonoBehaviour
{

    void Start()
    {

        Button cc = gameObject.GetComponent<Button>();
        cc.onClick.AddListener(delegate () { ScoreC(); });
    }

    public void ScoreC()
    {
        AA.mcq = 'C';
    }

}
