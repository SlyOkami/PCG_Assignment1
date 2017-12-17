using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collider2 : MonoBehaviour {

    LevelManager levelManager = new LevelManager();
    public Text score2;
    public int points2 = 0;
    public string nextLevel;
    public int maxScore2;
    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        if (points2 == maxScore2)
        {
            NextScene();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        points2++;
        GlobalScoreScript.Instance.totalScore2 = GlobalScoreScript.Instance.totalScore2 + 1;
        score2.text = points2.ToString() + "/" + maxScore2.ToString();
    }

    private void NextScene()
    {
        levelManager.LoadNewScene(nextLevel);
    }
}
