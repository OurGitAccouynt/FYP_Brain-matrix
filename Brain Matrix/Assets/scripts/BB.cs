using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BB : MonoBehaviour
{

    void Start()
    {

        Button bb = gameObject.GetComponent<Button>();
        bb.onClick.AddListener(delegate () { ScoreB(); });
    }

    public void ScoreB()
    {
        AA.mcq = 'B';
    }
}
