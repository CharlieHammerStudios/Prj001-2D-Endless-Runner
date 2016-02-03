﻿using UnityEngine;
using System.Collections;

public class Universe : MonoBehaviour {

    public bool immortal = true;

    public bool input_SpacePress = false;
    //public bool input_SpaceHold = false;
    //public bool input_SpaceRelease = false;

    // Use this for initialization
    void Start () {
        if (immortal)
        {
            // Make this object persist between scene changes
            DontDestroyOnLoad(transform.gameObject);
        }
    }
	
	// Update is called once per frame
	void Update () {
        CheckPlayerInput();
	}

    void CheckPlayerInput()
    {
        input_SpacePress = (Input.GetKeyDown(KeyCode.Space)) ? true : false;
    }
}
