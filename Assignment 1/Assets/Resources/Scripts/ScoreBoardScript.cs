using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoardScript : MonoBehaviour {
    public Text scoreBoard;
	// Use this for initialization
	void Start () {
		if(GlobalScoreScript.Instance.totalScore1 > GlobalScoreScript.Instance.totalScore2)
        {
            scoreBoard.text = "Red player wins with; "+ GlobalScoreScript.Instance.totalScore1.ToString() + " points!";
        }
        else
        {
            scoreBoard.text = "Blue player wins with; " + GlobalScoreScript.Instance.totalScore2.ToString() + " points!";
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
