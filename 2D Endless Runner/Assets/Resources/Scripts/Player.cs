﻿using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    private Universe universeSS;

    public float jumpStr = 1500;
    public bool isGrounded = false;
    public bool isJumping = false;
    public LayerMask groundCheckLayer;
    public float groundCheckRayLength = 0.55f;
    public RaycastHit2D groundCheckRayInfo;

    void Awake ()
    {
        universeSS = GameObject.FindGameObjectWithTag("Universe").GetComponent<Universe>();
    }

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        CheckForGround();
    }

    void FixedUpdate ()
    {
        if (isGrounded && !isJumping && universeSS.input_SpacePress)
        {
            isJumping = true;
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpStr));
            Debug.Log("Jump!");
        }
    }

    void CheckForGround()
    {
        groundCheckRayInfo = Physics2D.Raycast(GetComponent<Transform>().position, Vector2.down, groundCheckRayLength, groundCheckLayer);
        Debug.DrawRay(GetComponent<Transform>().position, Vector2.down * groundCheckRayLength, Color.red);

        if (groundCheckRayInfo.collider != null)
        {
            isGrounded = true;
            isJumping = false;
        }
        else
        {
            isGrounded = false;
        }
    }
}
