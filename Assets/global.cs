﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class global : MonoBehaviour {

    public int score;
	// Use this for initialization
	void Start () {
        score = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void addScore()
    {
        score += 1;
        print("score:" + score);


    }

}
