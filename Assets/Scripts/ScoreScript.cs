using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    
    public Text myScoreText;
    public static float ScoreNum;    

    void Start()
    {   
        myScoreText.text = "Score = " + ScoreNum;
    }

    
    void OnTriggerEnter2D(Collider2D Meteorite)
    {
        if(Meteorite.tag == "MyMeteorite")
        {
            ScoreNum += 1;
            myScoreText.text = "Score = " + ScoreNum;
            Destroy(Meteorite.gameObject);
        }
    }
}
