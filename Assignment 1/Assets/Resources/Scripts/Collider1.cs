using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collider1 : MonoBehaviour {

    LevelManager levelManager = new LevelManager();
    public Text score;
    public int points = 0;
    public string nextLevel;
    public int maxScore;
    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {

        if (points == maxScore)
        {
            NextScene();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        points++;
        GlobalScoreScript.Instance.totalScore1 = GlobalScoreScript.Instance.totalScore1 + 1;
        score.text = points.ToString() + "/" + maxScore.ToString();
    }

    private void NextScene()
    {

        levelManager.LoadNewScene(nextLevel);
    }

}
