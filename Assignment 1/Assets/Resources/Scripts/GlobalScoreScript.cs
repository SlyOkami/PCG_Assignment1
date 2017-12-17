using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalScoreScript : MonoBehaviour {

    public int totalScore1, totalScore2;
    private static GlobalScoreScript instance;
    public static GlobalScoreScript Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new GlobalScoreScript();
            }
            return instance;
        }
    }
    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
	}
}
