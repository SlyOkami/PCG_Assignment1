using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Brick : MonoBehaviour {

    public int maxHits;
    public static int breakableCount = 0;
    LevelManager levelManager = new LevelManager();
    int timesHit;


	// Use this for initialization
	void Start () {

        timesHit = 0;
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        timesHit++;
        //print(gameObject.name + ": " + timesHit);
        
        if (timesHit >= maxHits)
        {
            Destroy(gameObject);
        }
    }
}
