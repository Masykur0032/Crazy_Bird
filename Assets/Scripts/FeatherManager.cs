using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FeatherManager : MonoBehaviour
{
    public int score;
    public Text scoreTxt;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreTxt.text = "Feathers : " + score;
    }
}
